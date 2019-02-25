namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Date = new System.Windows.Forms.MonthCalendar();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.trackBarExp = new System.Windows.Forms.TrackBar();
            this.Weight = new System.Windows.Forms.Label();
            this.SitsNumber = new System.Windows.Forms.TrackBar();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitsNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Модель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Экипаж:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество пассажирских мест: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "год выпуска:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = " грузоподъемность:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата последнего тех. обслуживания:";
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(73, 16);
            this.maskedTextBoxID.Mask = "0000-0000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxID.TabIndex = 9;
            this.maskedTextBoxID.Tag = "false";
            this.maskedTextBoxID.ValidatingType = typeof(int);
            this.maskedTextBoxID.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox1_TypeValidationCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "СУ-24",
            "СУ-27",
            "Ил-2",
            "Боинг 737-8 MAX",
            "Аэроплан",
            "Боинг 767-300тм",
            "СУ-47",
            "Zvezda",
            "ИЛ-76 7011"});
            this.comboBox1.Location = new System.Drawing.Point(97, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Tag = "false";
            this.comboBox1.Text = "СУ-27";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Капитан",
            "Второй пилот",
            "Инжинер",
            "Бортпроводник 1",
            "Бортпроводник 2"});
            this.checkedListBox1.Location = new System.Drawing.Point(97, 182);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.Tag = "false";
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(411, 204);
            this.Date.Name = "Date";
            this.Date.TabIndex = 14;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(283, 204);
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
            this.Year.Size = new System.Drawing.Size(67, 20);
            this.Year.TabIndex = 15;
            this.Year.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // trackBarExp
            // 
            this.trackBarExp.LargeChange = 1;
            this.trackBarExp.Location = new System.Drawing.Point(283, 107);
            this.trackBarExp.Maximum = 37;
            this.trackBarExp.Minimum = 1;
            this.trackBarExp.Name = "trackBarExp";
            this.trackBarExp.Size = new System.Drawing.Size(224, 45);
            this.trackBarExp.SmallChange = 2;
            this.trackBarExp.TabIndex = 16;
            this.trackBarExp.TickFrequency = 5;
            this.trackBarExp.Value = 10;
            this.trackBarExp.Scroll += new System.EventHandler(this.trackBarExp_Scroll);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(394, 87);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(19, 13);
            this.Weight.TabIndex = 17;
            this.Weight.Text = "10";
            // 
            // SitsNumber
            // 
            this.SitsNumber.LargeChange = 1;
            this.SitsNumber.Location = new System.Drawing.Point(283, 36);
            this.SitsNumber.Maximum = 200;
            this.SitsNumber.Name = "SitsNumber";
            this.SitsNumber.Size = new System.Drawing.Size(224, 45);
            this.SitsNumber.SmallChange = 2;
            this.SitsNumber.TabIndex = 18;
            this.SitsNumber.TickFrequency = 5;
            this.SitsNumber.Value = 10;
            this.SitsNumber.Scroll += new System.EventHandler(this.SitsNumber_Scroll);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(462, 20);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(22, 13);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "10 ";
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(251, 400);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 38);
            this.buttonOK.TabIndex = 19;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "т.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(52, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "false";
            this.groupBox1.Text = "Тип";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Грузовой";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Военный";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "Пассажирский";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить производителя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.SitsNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.trackBarExp);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Создание рейса";
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitsNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MonthCalendar Date;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.TrackBar trackBarExp;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.TrackBar SitsNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}

