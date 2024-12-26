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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            zags = new Label();
            textBox1 = new TextBox();
            exit_button = new Button();
            SuspendLayout();
            // 
            // returnback
            // 
            returnback.Location = new Point(214, 197);
            returnback.Name = "returnback";
            returnback.Size = new Size(94, 29);
            returnback.TabIndex = 0;
            returnback.Text = "назад";
            returnback.UseVisualStyleBackColor = true;
            returnback.Click += return_back;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер акта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Дата выдачи";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(134, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // zags
            // 
            zags.AutoSize = true;
            zags.Location = new Point(10, 148);
            zags.Name = "zags";
            zags.Size = new Size(95, 20);
            zags.TabIndex = 6;
            zags.Text = "Номер ЗАГС";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(134, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 27);
            textBox1.TabIndex = 7;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(12, 197);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(94, 29);
            exit_button.TabIndex = 9;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // act
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 232);
            Controls.Add(exit_button);
            Controls.Add(textBox1);
            Controls.Add(zags);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(returnback);
            Name = "act";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Акты";
            FormClosed += act_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnback;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label zags;
        private TextBox textBox1;
        private Button exit_button;
    }
}