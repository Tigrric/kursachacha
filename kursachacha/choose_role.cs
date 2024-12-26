using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursachacha
{
    public partial class choose_role : Form
    {
        private bool _isAdmin;
        private int _roleId;
        private bool _employee;

        public choose_role(int selectedId, bool isAdmin, bool isemployee)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
            _roleId = selectedId;
            _employee = isemployee;
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            intermediateаform intermediateаform = new intermediateаform(_roleId, _isAdmin, _employee);
            intermediateаform.Show();
            this.Hide();
        }

        private void acts_Click(object sender, EventArgs e)
        {
            // Создание контекстного меню
            ContextMenuStrip menu = new ContextMenuStrip();

            // Добавление пунктов меню
            menu.Items.Add("Просмотреть", null, ViewActs_Click);
            menu.Items.Add("Добавить", null, AddAct_Click);

            // Отображение меню под кнопкой
            menu.Show(acts, new Point(0, acts.Height));
        }

        private void ViewActs_Click(object sender, EventArgs e)
        {
            act act = new act(_roleId, _employee);
            act.Show();
        }

        private void AddAct_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void zags_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextmenu = new ContextMenuStrip();

            contextmenu.Items.Add("Просмотреть", null, Viewzags_Click);
            contextmenu.Items.Add("Добавить", null, Addzags_Click);

            // Отображение меню под кнопкой
            contextmenu.Show(zags, new Point(0, acts.Height));
        }

        private void Viewzags_Click(object sender, EventArgs e)
        {
            zags zags = new zags(_roleId, _employee);
            zags.Show();
        }
        private void Addzags_Click(object sender, EventArgs e)
        {

        }

        private void applicant_Click(object sender, EventArgs e)
        {

        }

        private void choose_role_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}