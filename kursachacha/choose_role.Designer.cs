namespace kursachacha
{
    partial class choose_role
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
            acts = new Button();
            profile = new Button();
            admin = new Button();
            applicant = new Button();
            zags = new Button();
            SuspendLayout();
            // 
            // exit_button
            // 
            exit_button.Location = new Point(97, 221);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 0;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // acts
            // 
            acts.Location = new Point(79, 46);
            acts.Name = "acts";
            acts.Size = new Size(134, 29);
            acts.TabIndex = 1;
            acts.Text = "Акты";
            acts.UseVisualStyleBackColor = true;
            acts.Click += acts_Click;
            // 
            // profile
            // 
            profile.Location = new Point(79, 81);
            profile.Name = "profile";
            profile.Size = new Size(134, 29);
            profile.TabIndex = 2;
            profile.Text = "Личный кабинет";
            profile.UseVisualStyleBackColor = true;
            profile.Click += profile_Click;
            // 
            // admin
            // 
            admin.Location = new Point(59, 186);
            admin.Name = "admin";
            admin.Size = new Size(172, 29);
            admin.TabIndex = 3;
            admin.Text = "Администрирование";
            admin.UseVisualStyleBackColor = true;
            admin.Click += admin_Click;
            // 
            // applicant
            // 
            applicant.Location = new Point(79, 116);
            applicant.Name = "applicant";
            applicant.Size = new Size(134, 29);
            applicant.TabIndex = 4;
            applicant.Text = "Заявители";
            applicant.UseVisualStyleBackColor = true;
            applicant.Click += applicant_Click;
            // 
            // zags
            // 
            zags.Location = new Point(79, 151);
            zags.Name = "zags";
            zags.Size = new Size(134, 29);
            zags.TabIndex = 5;
            zags.Text = "ЗАГС";
            zags.UseVisualStyleBackColor = true;
            zags.Click += zags_Click;
            // 
            // choose_role
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 296);
            Controls.Add(zags);
            Controls.Add(applicant);
            Controls.Add(admin);
            Controls.Add(profile);
            Controls.Add(acts);
            Controls.Add(exit_button);
            Name = "choose_role";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += choose_role_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button exit_button;
        private Button acts;
        private Button profile;
        private Button admin;
        private Button applicant;
        private Button zags;
    }
}