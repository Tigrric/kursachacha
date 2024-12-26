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
    public partial class zags : Form
    {
        private int _roleid;
        private bool _isAdmin;
        public zags(int roleid, bool isAdmin)
        {
            InitializeComponent();
            _roleid = roleid;
            _isAdmin = isAdmin;
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
