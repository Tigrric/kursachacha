namespace kursachacha
{
    partial class zags
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
            exit_button = new Button();
            returnback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 97);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // exit_button
            // 
            exit_button.Location = new Point(12, 409);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 11;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // returnback
            // 
            returnback.Location = new Point(694, 409);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 12;
            returnback.Text = "Назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += returnback_Click;
            // 
            // zags
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnback);
            Controls.Add(exit_button);
            Controls.Add(label1);
            Name = "zags";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список ЗАГСов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button exit_button;
        private Button returnback;
    }
}