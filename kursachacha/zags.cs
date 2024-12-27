using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace kursachacha
{
    public partial class zags : Form
    {
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        private int _roleId;
        private bool _isAdmin;
        private bool _employee;

        public zags(int roleid, bool isAdmin, bool employee)
        {
            InitializeComponent();
            _roleId = roleid;
            _isAdmin = isAdmin;
            _employee = employee;
            LoadZagsData(); // Загрузка данных о ЗАГСах в ComboBox
        }

        private void LoadZagsData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"ID ЗАГС\" FROM ЗАГС", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxZags.Items.Add(reader["ID ЗАГС"].ToString());
                        }
                    }
                }
            }
        }


        private void comboBoxZags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxZags.SelectedItem != null) ;
            try
            {
                if (int.TryParse(comboBoxZags.SelectedItem.ToString(), out int selectedZagsId))
                {
                    using (var connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        // Запрос для получения информации о ЗАГСе
                        using (var commandZags = new NpgsqlCommand("SELECT область, город, район, наименование, телефон FROM ЗАГС WHERE \"ID ЗАГС\" = @Id", connection))
                        {
                            commandZags.Parameters.AddWithValue("@Id", selectedZagsId);
                            using (var readerZags = commandZags.ExecuteReader())
                            {
                                if (readerZags.Read())
                                {
                                    textBoxOblast.Text = readerZags.GetString(0);
                                    textBoxGorod.Text = readerZags.GetString(1);
                                    textBoxRaion.Text = readerZags.GetString(2);
                                    textBoxNaimenovanie.Text = readerZags.GetString(3);
                                    textBoxTelefon.Text = readerZags.GetString(4);
                                }
                                else
                                {
                                    MessageBox.Show("Информация о ЗАГСе не найдена.");
                                    ClearFields();
                                    return; // Прерываем выполнение, если данные о ЗАГСе не найдены
                                }
                            }
                        }

                        // Запрос для подсчета количества сотрудников
                        using (var commandEmployees = new NpgsqlCommand("SELECT COUNT(*) FROM Сотрудники WHERE \"ID загс\" = @Id", connection))
                        {
                            commandEmployees.Parameters.AddWithValue("@Id", selectedZagsId);
                            long employeeCount = (long)commandEmployees.ExecuteScalar();
                            textBoxEmployeeCount.Text = employeeCount.ToString();
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxOblast.Clear();
            textBoxGorod.Clear();
            textBoxRaion.Clear();
            textBoxNaimenovanie.Clear();
            textBoxTelefon.Clear();
            textBoxEmployeeCount.Clear(); // Очищаем поле количества сотрудников
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void returnback_Click(object sender, EventArgs e)
        {
            choose_role choose_role = new choose_role(_roleId, _isAdmin, _employee);
            choose_role.Show();
            this.Close();
        }
    }
}