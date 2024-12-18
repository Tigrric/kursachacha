using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachacha
{
    public partial class create_user : Form
    {
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        public create_user()
        {
            InitializeComponent();
        }
        private static string GetMD5Hash(string text)
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }

        private void create_user_click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                int? applicantId = string.IsNullOrEmpty(textBoxApplicantId.Text) ? (int?)null : int.Parse(textBoxApplicantId.Text);
                int? employeeId = string.IsNullOrEmpty(textBoxEmployeeId.Text) ? (int?)null : int.Parse(textBoxEmployeeId.Text);
                bool isAdmin = checkBoxAdmin.Checked;

                // Проверяем, что все обязательные поля заполнены
                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || (applicantId == null && employeeId == null))
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля: логин, пароль, и хотя бы один ID (заявителя или сотрудника).");
                    return;
                }

                // Проверяем, что ID заявителя и ID сотрудника не повторяются
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверка на дублирование ID заявителя только если он указан
                    if (applicantId != null)
                    {
                        using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM password WHERE \"id заявителя\" = @applicantId", connection))
                        {
                            command.Parameters.AddWithValue("@applicantId", applicantId);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Пользователь с таким ID заявителя уже существует.");
                                return;
                            }
                        }
                        if (isAdmin)
                        {
                            MessageBox.Show("Пользователь с ID заявителя не может быть администратором.");
                            return;
                        }
                    }

                    // Проверка на дублирование ID сотрудника только если он указан
                    if (employeeId != null)
                    {
                        using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM password WHERE  \"id сотрудника\" = @employeeId", connection))
                        {
                            command.Parameters.AddWithValue("@employeeId", employeeId);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Пользователь с таким ID сотрудника уже существует.");
                                return;
                            }
                        }
                    }

                    // Хешируем пароль
                    string hashedPassword = GetMD5Hash(password);

                    // Создаем нового пользователя в базе данных
                    using (var command = new NpgsqlCommand("INSERT INTO password (логин, пароль, \"id заявителя\",  \"id сотрудника\", админ) VALUES (@login, @password, @applicantId, @employeeId, @isAdmin)", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@applicantId", applicantId == null ? DBNull.Value : (object)applicantId);
                        command.Parameters.AddWithValue("@employeeId", employeeId == null ? DBNull.Value : (object)employeeId);
                        command.Parameters.AddWithValue("@isAdmin", isAdmin);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Пользователь успешно создан.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void gotochange_pass(object sender, EventArgs e)
        {
            change_pass change_pass = new change_pass();
            change_pass.Show();
            this.Hide();
        }

        private void exit_click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}