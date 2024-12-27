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
    public partial class profile : Form
    {
        private int _roleId;
        private bool _isAdmin;
        private bool _employee;
        public profile(int roleId, bool isAdmin, bool employee)
        {
            InitializeComponent();
            _roleId = roleId;
            _isAdmin = isAdmin;
            _employee = employee;
            ConfigureControls();
        }
        private void ConfigureControls()
        {
            if (_employee)
            {
                id_zags.Visible = true;
                id_employee.Visible = false;
                textBoxPasport.Visible=false;
                textBox_id_zags.Visible=true;
                b_day.Visible = false;
                b_day_date.Visible = false;
                pasport.Visible = false;
                returnback.Visible = false;
                score.Visible = true;
                textBoxscore.Visible = true;
            }
            else 
            {
                id_zags.Visible = false; 
                id_employee.Visible = true;
                textBoxPasport.Visible = true;
                b_day.Visible = true;
                b_day_date.Visible = true;
                textBox_id_zags.Visible = false;
                pasport.Visible = true;
                returnback.Visible = true;
                score.Visible = false;
                textBoxscore.Visible = false;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void returnback_Click(object sender, EventArgs e)
        {
            choose_data choose_data = new choose_data(_roleId, _isAdmin, _employee);
            choose_data.Show();
            this.Close();
        }
    }
}
