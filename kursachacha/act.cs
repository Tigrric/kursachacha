using Npgsql;
using System;
using System.Windows.Forms;

namespace kursachacha
{
    public partial class act : Form
    {
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        private int _roleId;
        private bool _employee;

        public act(int selectId, bool employee)
        {
            InitializeComponent();
            _roleId = selectId;
            _employee = employee;
            ConfigureControls();
            LoadComboBoxData();
        }

        private void ConfigureControls()
        {
            zags.Visible = _employee;
            textBox1.Visible = _employee;
        }

        private void return_back(object sender, EventArgs e)
        {
            choose_data choose_Data = new choose_data(_roleId, _employee);
            choose_Data.Show();
            this.Close();
        }

        private void LoadComboBoxData()
        {
            comboBox1.Items.Clear();

            string query;
            if (_employee)
            {
                query = "SELECT \"Номер\" FROM \"Акт\"";
            }
            else
            {
                query = "SELECT \"Номер\" FROM \"Акт\" WHERE \"ID заявителя\" = @selectedId";
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        if (!_employee)
                        {
                            command.Parameters.AddWithValue("@selectedId", _roleId);
                        }

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["Номер"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedActNumber = comboBox1.SelectedItem.ToString();

            if (!int.TryParse(selectedActNumber, out int actNumber))
            {
                MessageBox.Show("Неверный формат номера акта.");
                return;
            }

            string query;
            if (_employee)
            {
                query = @"SELECT ""Дата выдачи"", ""ID ЗАГС"" FROM ""Акт"" WHERE ""Номер"" = @actNumber";
            }
            else
            {
                query = @"SELECT ""Дата выдачи"", ""ID ЗАГС"" FROM ""Акт"" WHERE ""Номер"" = @actNumber AND ""ID заявителя"" = @selectedId";
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@actNumber", actNumber);
                        if (!_employee)
                        {
                            command.Parameters.AddWithValue("@selectedId", _roleId);
                        }

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dateTimePicker1.Value = reader.GetDateTime(reader.GetOrdinal("Дата выдачи"));
                                if (_employee) // Только если контролы видимы
                                {
                                    textBox1.Text = reader.GetInt32(reader.GetOrdinal("ID ЗАГС")).ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Акт не найден.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void act_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}