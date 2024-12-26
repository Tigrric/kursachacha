namespace kursachacha
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBox = new TextBox();
            PasswordBox = new TextBox();
            entrance = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Location = new Point(86, 50);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(127, 27);
            loginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(86, 122);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(127, 27);
            PasswordBox.TabIndex = 1;
            // 
            // entrance
            // 
            entrance.Location = new Point(103, 173);
            entrance.Name = "entrance";
            entrance.Size = new Size(70, 29);
            entrance.TabIndex = 2;
            entrance.Text = "Вход";
            entrance.UseVisualStyleBackColor = true;
            entrance.Click += entrance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 225);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(entrance);
            Controls.Add(PasswordBox);
            Controls.Add(loginBox);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            FormClosed += login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox;
        private TextBox PasswordBox;
        private Button entrance;
        private Label label1;
        private Label label2;
    }
}
