namespace kursachacha
{
    partial class choose_data
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
            act = new Button();
            profile = new Button();
            exit_button = new Button();
            SuspendLayout();
            // 
            // act
            // 
            act.Location = new Point(89, 31);
            act.Name = "act";
            act.Size = new Size(94, 29);
            act.TabIndex = 0;
            act.Text = "Акты";
            act.UseVisualStyleBackColor = true;
            act.Click += go_to_act;
            // 
            // profile
            // 
            profile.Location = new Point(51, 89);
            profile.Name = "profile";
            profile.Size = new Size(166, 29);
            profile.TabIndex = 1;
            profile.Text = "Личный кабинет";
            profile.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(89, 146);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 2;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_click;
            // 
            // choose_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 214);
            Controls.Add(exit_button);
            Controls.Add(profile);
            Controls.Add(act);
            Name = "choose_data";
            Text = "Выбор данных";
            ResumeLayout(false);
        }

        #endregion

        private Button act;
        private Button profile;
        private Button exit_button;
    }
}