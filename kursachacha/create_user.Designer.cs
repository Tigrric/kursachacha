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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            // 
            button1.Location = new Point(126, 242);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 277);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 11;
            button2.Text = "Изменить пароль";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(126, 333);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 368);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxAdmin);
            Controls.Add(label4);
            Controls.Add(Никнейм);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(textBoxApplicantId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Создание пользователей";
            Load += button1_Click;
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}