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
    public partial class intermediateаform : Form
    {
        public int _roleId;
        public bool _isAdmin;
        public bool _employee;

        private add_employee _employeeForm; // Переименовано для ясности
        private create_user _createUserForm;
        private change_pass _changePassForm;

        public intermediateаform(int roleId, bool isAdmin, bool employee)
        {
            InitializeComponent();
            _roleId = roleId;
            _isAdmin = isAdmin;
            _employee = employee;
        }

        private void returnback_Click(object sender, EventArgs e)
        {
            choose_role choose_role = new choose_role(_roleId, _isAdmin, _employee);
            choose_role.Show();
            this.Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gotochange_pass(object sender, EventArgs e)
        {
            _changePassForm = new change_pass(_roleId, _isAdmin, _employee);
            _changePassForm.FormClosed += ChildFormClosed; // Упрощенное подписание на событие
            _changePassForm.Show();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            _createUserForm = new create_user(_roleId, _isAdmin, _employee);
            _createUserForm.FormClosed += ChildFormClosed; // Упрощенное подписание на событие
            _createUserForm.Show();
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            _employeeForm = new add_employee(_roleId, _isAdmin, _employee);
            _employeeForm.FormClosed += ChildFormClosed; // Упрощенное подписание на событие
            _employeeForm.Show();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // Проверяем, закрылась ли одна из дочерних форм.  Если да, закрываем родительскую.
            Form closedForm = sender as Form;
            if (closedForm == _createUserForm || closedForm == _changePassForm || closedForm == _employeeForm)
            {
                this.Close();
            }
        }
    }
}