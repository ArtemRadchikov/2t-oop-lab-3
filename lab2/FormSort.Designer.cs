namespace lab2
{
    partial class FormSort
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSortFoi = new System.Windows.Forms.Button();
            this.buttonSortDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(228, 43);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(334, 209);
            this.textBoxResult.TabIndex = 25;
            // 
            // buttonSortFoi
            // 
            this.buttonSortFoi.Location = new System.Drawing.Point(12, 41);
            this.buttonSortFoi.Name = "buttonSortFoi";
            this.buttonSortFoi.Size = new System.Drawing.Size(186, 23);
            this.buttonSortFoi.TabIndex = 27;
            this.buttonSortFoi.Text = "Сортировать по ФИО капитана";
            this.buttonSortFoi.UseVisualStyleBackColor = true;
            this.buttonSortFoi.Click += new System.EventHandler(this.buttonSortFio_Click);
            // 
            // buttonSortDate
            // 
            this.buttonSortDate.Location = new System.Drawing.Point(12, 86);
            this.buttonSortDate.Name = "buttonSortDate";
            this.buttonSortDate.Size = new System.Drawing.Size(186, 48);
            this.buttonSortDate.TabIndex = 27;
            this.buttonSortDate.Text = "Сортировать по дате последнего тех. обслуживания";
            this.buttonSortDate.UseVisualStyleBackColor = true;
            this.buttonSortDate.Click += new System.EventHandler(this.buttonSortDate_Click);
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 276);
            this.Controls.Add(this.buttonSortDate);
            this.Controls.Add(this.buttonSortFoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Name = "FormSort";
            this.Text = "Окно сортировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSortFoi;
        private System.Windows.Forms.Button buttonSortDate;
    }
}