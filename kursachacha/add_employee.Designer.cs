namespace kursachacha
{
    partial class add_employee
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
            exit_button = new Button();
            returnback = new Button();
            username = new TextBox();
            name_user = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            surname = new TextBox();
            fathername = new TextBox();
            telnumber = new TextBox();
            id_zags = new TextBox();
            id_employee = new TextBox();
            job_title = new TextBox();
            add_user = new Button();
            SuspendLayout();
            // 
            // exit_button
            // 
            exit_button.Location = new Point(47, 238);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 10;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_Click;
            // 
            // returnback
            // 
            returnback.Location = new Point(559, 238);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 11;
            returnback.Text = "Назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += returnback_Click;
            // 
            // username
            // 
            username.Location = new Point(146, 52);
            username.Name = "username";
            username.Size = new Size(210, 27);
            username.TabIndex = 12;
            // 
            // name_user
            // 
            name_user.AutoSize = true;
            name_user.Location = new Point(47, 59);
            name_user.Name = "name_user";
            name_user.Size = new Size(39, 20);
            name_user.TabIndex = 13;
            name_user.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 100);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 14;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 138);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 15;
            label2.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 179);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 16;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 59);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 17;
            label4.Text = "Номер ЗАГСа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 100);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 18;
            label5.Text = "Номер сотрудника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 138);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 19;
            label6.Text = "Должность";
            // 
            // surname
            // 
            surname.Location = new Point(146, 93);
            surname.Name = "surname";
            surname.Size = new Size(210, 27);
            surname.TabIndex = 20;
            // 
            // fathername
            // 
            fathername.Location = new Point(146, 131);
            fathername.Name = "fathername";
            fathername.Size = new Size(210, 27);
            fathername.TabIndex = 21;
            // 
            // telnumber
            // 
            telnumber.Location = new Point(146, 172);
            telnumber.Name = "telnumber";
            telnumber.Size = new Size(210, 27);
            telnumber.TabIndex = 22;
            // 
            // id_zags
            // 
            id_zags.Location = new Point(538, 52);
            id_zags.Name = "id_zags";
            id_zags.Size = new Size(115, 27);
            id_zags.TabIndex = 23;
            // 
            // id_employee
            // 
            id_employee.Location = new Point(538, 97);
            id_employee.Name = "id_employee";
            id_employee.Size = new Size(115, 27);
            id_employee.TabIndex = 24;
            // 
            // job_title
            // 
            job_title.Location = new Point(538, 135);
            job_title.Name = "job_title";
            job_title.Size = new Size(115, 27);
            job_title.TabIndex = 25;
            // 
            // add_user
            // 
            add_user.Location = new Point(395, 179);
            add_user.Name = "add_user";
            add_user.Size = new Size(258, 29);
            add_user.TabIndex = 26;
            add_user.Text = "Добавить сотрудника";
            add_user.UseVisualStyleBackColor = true;
            add_user.Click += add_user_Click;
            // 
            // add_employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 280);
            Controls.Add(add_user);
            Controls.Add(job_title);
            Controls.Add(id_employee);
            Controls.Add(id_zags);
            Controls.Add(telnumber);
            Controls.Add(fathername);
            Controls.Add(surname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_user);
            Controls.Add(username);
            Controls.Add(returnback);
            Controls.Add(exit_button);
            Name = "add_employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление сотрудника";
            FormClosed += add_employee_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit_button;
        private Button returnback;
        private TextBox username;
        private Label name_user;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox surname;
        private TextBox fathername;
        private TextBox telnumber;
        private TextBox id_zags;
        private TextBox id_employee;
        private TextBox job_title;
        private Button add_user;
    }
}