namespace kursachacha
{
    partial class intermediateаform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            returnback = new Button();
            exit_button = new Button();
            add_employee = new Button();
            add_user = new Button();
            changepass = new Button();
            SuspendLayout();
            // 
            // returnback
            // 
            returnback.Location = new Point(173, 212);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 13;
            returnback.Text = "назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += returnback_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(28, 212);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 12;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_click;
            // 
            // add_employee
            // 
            add_employee.Location = new Point(28, 66);
            add_employee.Name = "add_employee";
            add_employee.Size = new Size(239, 29);
            add_employee.TabIndex = 14;
            add_employee.Text = "Добавить сотрудника";
            add_employee.UseVisualStyleBackColor = true;
            add_employee.Click += add_employee_Click;
            // 
            // add_user
            // 
            add_user.Location = new Point(28, 101);
            add_user.Name = "add_user";
            add_user.Size = new Size(239, 29);
            add_user.TabIndex = 15;
            add_user.Text = "Добавить пользователя";
            add_user.UseVisualStyleBackColor = true;
            add_user.Click += add_user_Click;
            // 
            // changepass
            // 
            changepass.Location = new Point(28, 136);
            changepass.Name = "changepass";
            changepass.Size = new Size(239, 29);
            changepass.TabIndex = 16;
            changepass.Text = "Изменить пароль";
            changepass.UseVisualStyleBackColor = true;
            changepass.Click += gotochange_pass;
            // 
            // intermediateаform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 264);
            Controls.Add(changepass);
            Controls.Add(add_user);
            Controls.Add(add_employee);
            Controls.Add(returnback);
            Controls.Add(exit_button);
            Name = "intermediateаform";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button returnback;
        private Button exit_button;
        private Button add_employee;
        private Button add_user;
        private Button changepass;
    }
}