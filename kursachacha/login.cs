using Npgsql;
using System.Security.Cryptography;
using System.Text;

namespace kursachacha
{
    public partial class login : Form
    {
        public static int selectedId { get; private set; } // Статическая переменная для хранения ID заявителя
        public static bool isAdmin;
        public static bool isemployee;

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

        private void entrance_Click(object sender, EventArgs e)
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
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"id заявителя\", \"id сотрудника\", админ, работник FROM password WHERE логин = @login AND пароль = @password", connection))
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
                                isAdmin = reader.GetBoolean(reader.GetOrdinal("админ"));
                                bool isemployee = reader.GetBoolean(reader.GetOrdinal("работник"));
                                isemployee = reader.GetBoolean(reader.GetOrdinal("работник"));

                                if (idЗаявителя == DBNull.Value && idСотрудника == DBNull.Value)
                                {
                                    MessageBox.Show("Вас нет в базе.");
                                }
                                else if (idСотрудника != DBNull.Value)
                                {
                                    selectedId = Convert.ToInt32(idСотрудника);

                                    choose_role choose_role = new choose_role(selectedId, isAdmin, isemployee);
                                    choose_role.Show();
                                    this.Hide();
                                }
                                else if (idЗаявителя != DBNull.Value)
                                {
                                    selectedId = Convert.ToInt32(idЗаявителя); // Сохраняем ID заявителя

                                    choose_data choose_data = new choose_data(selectedId, isAdmin ,isemployee);
                                    choose_data.Show();
                                    this.Hide();
                                }
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

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}