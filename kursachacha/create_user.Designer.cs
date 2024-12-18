namespace kursachacha
{
    partial class create_user
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
            label1 = new Label();
            label2 = new Label();
            textBoxApplicantId = new TextBox();
            textBoxEmployeeId = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            Никнейм = new Label();
            label4 = new Label();
            checkBoxAdmin = new CheckBox();
            createuser = new Button();
            changepass = new Button();
            exit_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "id заявителя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 47);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "id сотрудника";
            // 
            // textBoxApplicantId
            // 
            textBoxApplicantId.Location = new Point(175, 9);
            textBoxApplicantId.Name = "textBoxApplicantId";
            textBoxApplicantId.Size = new Size(45, 27);
            textBoxApplicantId.TabIndex = 2;
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(175, 47);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(45, 27);
            textBoxEmployeeId.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(175, 86);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(125, 27);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(175, 139);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // Никнейм
            // 
            Никнейм.AutoSize = true;
            Никнейм.Location = new Point(60, 89);
            Никнейм.Name = "Никнейм";
            Никнейм.Size = new Size(73, 20);
            Никнейм.TabIndex = 6;
            Никнейм.Text = "Никнейм";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 139);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Пароль";
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(175, 185);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(85, 24);
            checkBoxAdmin.TabIndex = 8;
            checkBoxAdmin.Text = "Админ?";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // createuser
            // 
            createuser.Location = new Point(126, 242);
            createuser.Name = "createuser";
            createuser.Size = new Size(94, 29);
            createuser.TabIndex = 10;
            createuser.Text = "Создать";
            createuser.UseVisualStyleBackColor = true;
            createuser.Click += create_user_click;
            // 
            // changepass
            // 
            changepass.Location = new Point(98, 277);
            changepass.Name = "changepass";
            changepass.Size = new Size(152, 29);
            changepass.TabIndex = 11;
            changepass.Text = "Изменить пароль";
            changepass.UseVisualStyleBackColor = true;
            changepass.Click += gotochange_pass;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(126, 333);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 12;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_click;
            // 
            // create_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 368);
            Controls.Add(exit_button);
            Controls.Add(changepass);
            Controls.Add(createuser);
            Controls.Add(checkBoxAdmin);
            Controls.Add(label4);
            Controls.Add(Никнейм);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(textBoxApplicantId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "create_user";
            Text = "Создание пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxApplicantId;
        private TextBox textBoxEmployeeId;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label Никнейм;
        private Label label4;
        private CheckBox checkBoxAdmin;
        private Button createuser;
        private Button changepass;
        private Button exit_button;
    }
}