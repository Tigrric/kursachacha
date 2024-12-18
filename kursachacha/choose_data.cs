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
        public choose_data()
        {
            InitializeComponent();
        }

        private void exit_click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void go_to_act(object sender, EventArgs e)
        {
            act act = new act();
            act.Show();
            this.Hide();
        }
    }
}
