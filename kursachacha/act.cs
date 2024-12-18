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
    public partial class act : Form
    {
        private readonly string connectionString = "Server=localhost; port=5432; user id=postgres; password=1111; database=kurs";
        public act()
        {
            InitializeComponent();
        }

        private void return_back(object sender, EventArgs e)
        {
            choose_data choose_Data = new choose_data();
            choose_Data.Show();
            this.Close();
        }
    }
}
