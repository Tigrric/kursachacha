namespace kursachacha
{
    partial class change_pass
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            update = new Button();
            returnback = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            exit_button = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(138, 152);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(125, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(138, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // update
            // 
            update.Location = new Point(111, 251);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 2;
            update.Text = "обновить";
            update.UseVisualStyleBackColor = true;
            update.Click += upd;
            // 
            // returnback
            // 
            returnback.Location = new Point(111, 286);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 3;
            returnback.Text = "вернуться";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += return_back;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 214);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "Новый пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 155);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Логин";
            // 
            // label1
            // 
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(300, 75);
            label1.TabIndex = 7;
            label1.Text = "Данное окно предназначено для обновление пароля, если вы случйно перешли сюда, то нажмите \"вернуться\"";
            // 
            // exit_button
            // 
            exit_button.Location = new Point(111, 321);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 8;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_click;
            // 
            // change_pass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 363);
            Controls.Add(exit_button);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(returnback);
            Controls.Add(update);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "change_pass";
            Text = "Изменение пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button update;
        private Button returnback;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button exit_button;
    }
}