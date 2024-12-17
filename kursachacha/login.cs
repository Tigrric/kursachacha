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
                    // ��������� ������� ������������ � ��������� ������� � �������
                    if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("������� ����� � ������.");
                        return;
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"id ���������\", \"id ����������\", ����� FROM password WHERE ����� = @login AND ������ = @password", connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ������������ ������, ��������� ��� ����
                                object id��������� = reader["id ���������"];
                                object id���������� = reader["id ����������"];
                                bool isAdmin = reader.GetBoolean(reader.GetOrdinal("�����"));

                                if (id��������� == DBNull.Value && id���������� == DBNull.Value)
                                {
                                    MessageBox.Show("��� ��� � ����.");
                                }
                                else if (id���������� != DBNull.Value && isAdmin)
                                {
                                    create_user create_user = new create_user();
                                    create_user.Show();
                                    this.Hide();
                                }
                                else if (id��������� != DBNull.Value)
                                {
                                    choose_data choose_data = new choose_data();
                                    choose_data.Show();
                                    this.Hide();
                                }
                                // ����� ����� �������� ��������� ��� ������ �����
                            }
                            else
                            {
                                MessageBox.Show("�������� ����� ��� ������.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ����������� � ���� ������: " + ex.Message);
            }
        }
    }
}