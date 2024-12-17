using Npgsql;
using System.Security.Cryptography;
using System.Text;

namespace kursachacha
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }
        string connectionString1 = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = GetMD5Hash(PasswordBox.Text);

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString1))
                {
                    connection.Open();
                    // Проверяем наличие пользователя с указанным логином и паролем
                    if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Введите логин и пароль.");
                        return;
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"id заявителя\", \"id сотрудника\", админ FROM password WHERE логин = @login AND пароль = @password", connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Пользователь найден, проверяем его роль
                                object idЗаявителя = reader["id заявителя"];
                                object idСотрудника = reader["id сотрудника"];
                                bool isAdmin = reader.GetBoolean(reader.GetOrdinal("админ"));

                                if (idЗаявителя == DBNull.Value && idСотрудника == DBNull.Value)
                                {
                                    MessageBox.Show("Вас нет в базе.");
                                }
                                else if (idСотрудника != DBNull.Value && isAdmin)
                                {
                                    create_user create_user = new create_user();
                                    create_user.Show();
                                    this.Hide();
                                }
                                else if (idЗаявителя != DBNull.Value)
                                {
                                    choose_data choose_data = new choose_data();
                                    choose_data.Show();
                                    this.Hide();
                                }
                                // Здесь можно добавить обработку для других ролей
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
            }
        }
    }
}