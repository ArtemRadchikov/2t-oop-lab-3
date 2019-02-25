namespace lab2
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Италия",
            "Европейский Союз",
            "США",
            "Канада",
            "Великобритания",
            "Чехия",
            "Франция",
            "Канада",
            "Франция",
            "Бразилия",
            "Нидерланды",
            "Германия",
            "ОАЭ",
            "Китай",
            "Израиль",
            "Швеция",
            "Китай",
            "Франция",
            "Россия"});
            this.comboBox1.Location = new System.Drawing.Point(96, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Россия";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxEmpty_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Страна:";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(333, 91);
            this.Year.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(75, 20);
            this.Year.TabIndex = 17;
            this.Year.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "год создания:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Пассажирские",
            "Грузовые",
            "Военные"});
            this.checkedListBox1.Location = new System.Drawing.Point(446, 62);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 49);
            this.checkedListBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Типы самолетов:";
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(266, 133);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 38);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 192);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Проиводитель";
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
    }
}