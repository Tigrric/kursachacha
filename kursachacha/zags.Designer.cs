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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxEmployeeCount = new TextBox();
            textBoxNaimenovanie = new TextBox();
            textBoxOblast = new TextBox();
            textBoxGorod = new TextBox();
            textBoxRaion = new TextBox();
            textBoxTelefon = new TextBox();
            comboBoxZags = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Номер ЗАГСа";
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
            returnback.Location = new Point(292, 409);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 12;
            returnback.Text = "Назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += returnback_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 13;
            label2.Text = "Количество сотрудников";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 14;
            label3.Text = "Наименование";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 15;
            label4.Text = "Область";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 16;
            label5.Text = "Город";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 296);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 17;
            label6.Text = "Район";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 340);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 18;
            label7.Text = "Номер телефона";
            // 
            // textBoxEmployeeCount
            // 
            textBoxEmployeeCount.Location = new Point(201, 103);
            textBoxEmployeeCount.Name = "textBoxEmployeeCount";
            textBoxEmployeeCount.Size = new Size(185, 27);
            textBoxEmployeeCount.TabIndex = 19;
            // 
            // textBoxNaimenovanie
            // 
            textBoxNaimenovanie.Location = new Point(201, 151);
            textBoxNaimenovanie.Name = "textBoxNaimenovanie";
            textBoxNaimenovanie.Size = new Size(185, 27);
            textBoxNaimenovanie.TabIndex = 20;
            // 
            // textBoxOblast
            // 
            textBoxOblast.Location = new Point(201, 202);
            textBoxOblast.Name = "textBoxOblast";
            textBoxOblast.Size = new Size(185, 27);
            textBoxOblast.TabIndex = 21;
            // 
            // textBoxGorod
            // 
            textBoxGorod.Location = new Point(201, 246);
            textBoxGorod.Name = "textBoxGorod";
            textBoxGorod.Size = new Size(185, 27);
            textBoxGorod.TabIndex = 22;
            // 
            // textBoxRaion
            // 
            textBoxRaion.Location = new Point(201, 289);
            textBoxRaion.Name = "textBoxRaion";
            textBoxRaion.Size = new Size(185, 27);
            textBoxRaion.TabIndex = 23;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(201, 333);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(185, 27);
            textBoxTelefon.TabIndex = 24;
            // 
            // comboBoxZags
            // 
            comboBoxZags.FormattingEnabled = true;
            comboBoxZags.Location = new Point(201, 55);
            comboBoxZags.Name = "comboBoxZags";
            comboBoxZags.Size = new Size(125, 28);
            comboBoxZags.TabIndex = 25;
            comboBoxZags.SelectedIndexChanged += comboBoxZags_SelectedIndexChanged;
            // 
            // zags
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 447);
            Controls.Add(comboBoxZags);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxRaion);
            Controls.Add(textBoxGorod);
            Controls.Add(textBoxOblast);
            Controls.Add(textBoxNaimenovanie);
            Controls.Add(textBoxEmployeeCount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxEmployeeCount;
        private TextBox textBoxNaimenovanie;
        private TextBox textBoxOblast;
        private TextBox textBoxGorod;
        private TextBox textBoxRaion;
        private TextBox textBoxTelefon;
        private ComboBox comboBoxZags;
    }
}