namespace kursachacha
{
    partial class act
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
            SuspendLayout();
            // 
            // returnback
            // 
            returnback.Location = new Point(12, 409);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 0;
            returnback.Text = "назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += return_back;
            // 
            // act
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnback);
            Name = "act";
            Text = "Акты";
            ResumeLayout(false);
        }

        #endregion

        private Button returnback;
    }
}