namespace kursachacha
{
    partial class info
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
            continue_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 107);
            label1.TabIndex = 0;
            label1.Text = "Внимание!\r\nДля закрытия прораммы необходимо перейти в форму авторизации, после этого можете закрывать программу";
            // 
            // continue_button
            // 
            continue_button.Location = new Point(32, 119);
            continue_button.Name = "continue_button";
            continue_button.Size = new Size(164, 29);
            continue_button.TabIndex = 1;
            continue_button.Text = "Продолжить";
            continue_button.UseVisualStyleBackColor = true;
            continue_button.Click += continue_button_Click;
            // 
            // info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 162);
            Controls.Add(continue_button);
            Controls.Add(label1);
            Name = "info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "info";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button continue_button;
    }
}