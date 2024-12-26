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
    public partial class change_pass : Form
    {
        private bool _isAdmin;
        private int _roleId;
        private bool _employee;
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        public change_pass(int selectedId, bool isAdmin, bool employee)
        {
            InitializeComponent();
            _roleId = selectedId;
            _isAdmin = isAdmin;

            ConfigureControls();
            _employee = employee;
        }
        private void ConfigureControls()
        {
            update.Visible = true;
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

        private void upd(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string login = textBoxLogin.Text;
            string newPassword = textBoxPassword.Text;

            // Проверяем, что поля заполнены
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Пожалуйста, заполните поля: логин и новый пароль.");
                return;
            }

            // Хешируем новый пароль
            string hashedNewPassword = GetMD5Hash(newPassword);

            // Проверяем, не совпадает ли новый пароль со старым
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT пароль FROM password WHERE логин = @login", connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    string oldHashedPassword = command.ExecuteScalar()?.ToString();

                    if (oldHashedPassword != null && hashedNewPassword == oldHashedPassword)
                    {
                        MessageBox.Show("Новый пароль не должен совпадать со старым.");
                        return;
                    }
                }
            }

            // Обновляем пароль в базе данных
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE password SET пароль = @hashedNewPassword WHERE логин = @login", connection))
                {
                    command.Parameters.AddWithValue("@hashedNewPassword", hashedNewPassword);
                    command.Parameters.AddWithValue("@login", login);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пароль успешно изменен.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином не найден.");
                    }
                }
            }
        }

        private void return_back(object sender, EventArgs e)
        {
            intermediateаform intermediateаform = new intermediateаform(_roleId, _isAdmin, _employee);
            intermediateаform.Show();
            this.Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void change_pass_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}