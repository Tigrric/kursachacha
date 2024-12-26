using Npgsql;
using System.Text.RegularExpressions;
using System;


namespace kursachacha
{
    public partial class add_employee : Form
    {
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        private bool _isAdmin;
        private int _roleId;
        private bool _employee;
        public add_employee(int selectedId, bool isAdmin, bool employee)
        {
            InitializeComponent();
            _roleId = selectedId;
            _employee = employee;
            _isAdmin = isAdmin;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void returnback_Click(object sender, EventArgs e)
        {
            choose_role choose_role = new choose_role(_roleId, _isAdmin, _employee);
            choose_role.Show();
            this.Hide();
        }

        private void add_employee_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void add_user_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(id_employee.Text) || string.IsNullOrEmpty(id_zags.Text) ||
                string.IsNullOrEmpty(surname.Text) || string.IsNullOrEmpty(username.Text) ||
                string.IsNullOrEmpty(telnumber.Text) || string.IsNullOrEmpty(job_title.Text))
            {
                MessageBox.Show("Все поля, кроме отчества, должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на корректность ввода
            if (!Regex.IsMatch(surname.Text, @"^[а-яА-Я-]+$") || !Regex.IsMatch(username.Text, @"^[а-яА-Я-]+$") ||
                (surname.Text.Length > 30) || (username.Text.Length > 30) ||
                (!string.IsNullOrEmpty(fathername.Text) && !Regex.IsMatch(fathername.Text, @"^[а-яА-Я]+$")) ||
                !Regex.IsMatch(telnumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Некорректный формат данных. Проверьте поля 'Фамилия', 'Имя', 'Отчество' и 'Телефон'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();


                    using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM ЗАГС WHERE \"ID ЗАГС\" = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(id_zags.Text));
                        long count = (long)command.ExecuteScalar(); // Изменение типа на long
                        if (count == 0)
                        {
                            MessageBox.Show("ID ЗАГСа не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                    using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM Сотрудники WHERE \"ID сотрудника\" = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(id_employee.Text));
                        long count = (long)command.ExecuteScalar(); 
                        if (count > 0)
                        {
                            MessageBox.Show("ID сотрудника уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Добавление сотрудника
                    using (var command = new NpgsqlCommand("INSERT INTO Сотрудники (\"ID сотрудника\", \"ID загс\", Фамилия, Имя, Отчество, телефон, Должность) VALUES (@id, @id_zags, @surname, @name, @patronymic, @phone, @position)", connection))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(id_employee.Text));
                        command.Parameters.AddWithValue("@id_zags", int.Parse(id_zags.Text));
                        command.Parameters.AddWithValue("@surname", surname.Text);
                        command.Parameters.AddWithValue("@name", username.Text);
                        command.Parameters.AddWithValue("@patronymic", fathername.Text);
                        command.Parameters.AddWithValue("@phone", telnumber.Text);
                        command.Parameters.AddWithValue("@position", job_title.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
