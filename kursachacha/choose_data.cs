using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachacha
{
    public partial class choose_data : Form
    {
        // Поле для хранения selectedId
        public int _roleId { get; set; }
        public bool _employee;


        public choose_data()
        {
            InitializeComponent();
        }

        // Конструктор с параметром
        public choose_data(int selectedId, bool employee) : this()
        {
            _roleId = selectedId;
            _employee = employee;
        }

        private void exit_click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void go_to_act(object sender, EventArgs e)
        {
            // Передача selectedId в форму act
            act actForm = new act(_roleId, _employee);
            actForm.Show();
            this.Hide();
        }

        private void choose_data_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}