using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace lab2
{
    public partial class Form1 : Form
    {
        public string type;

        public Form1()
        {
            InitializeComponent();
            deserializeFromBase();

            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Timer_Tick(object sender,EventArgs e)
        {
            toolStripStatusLabelDT.Text = DateTime.Now.ToString();
        }

        void deserializeFromBase()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aircraft>), new Type[] { typeof(List<Member>), typeof(Member), typeof(Owner) });
            FileInfo file = new FileInfo("base.xml");
            if (file.Exists)
            {
                using (StreamReader fs = new StreamReader("base.xml"))
                {
                    AircraftMembers.aircrafts = xmlSerializer.Deserialize(fs) as List<Aircraft>;
                }
            }

            toolStripStatusLabelCouner.Text = AircraftMembers.aircrafts.Count().ToString();
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Text = ((CheckedListBox)sender).Text;
            form2.labelPosition.Text = form2.Text;
            form2.ShowDialog();
            if (AircraftMembers.IsOk)
            {
                AircraftMembers.IsOk = false;
            }           
        }

        private void trackBarExp_Scroll(object sender, EventArgs e)
        {
            Weight.Text = trackBarExp.Value.ToString();
        }

        private void SitsNumber_Scroll(object sender, EventArgs e)
        {
            labelNumber.Text = SitsNumber.Value.ToString();

        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            buttonOK.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft(maskedTextBoxID.Text, type, (string)comboBox1.SelectedItem, AircraftMembers.members, int.Parse(labelNumber.Text),
                  int.Parse(Weight.Text), (int)Year.Value, Date.SelectionStart.ToShortDateString(), AircraftMembers.form3Owner);

            var results= new List<ValidationResult>();
            var context= new ValidationContext(aircraft);
           
            if (Validator.TryValidateObject(aircraft, context,results, true))
            {

                AircraftMembers.aircrafts.Add(aircraft);
                toolStripStatusLabelCouner.Text = AircraftMembers.aircrafts.Count().ToString();


                serializToBase();
                AircraftMembers.members.RemoveAll(i => true);
                AircraftMembers.form3Owner = null;
                checkedListBox1.ClearSelected();

                ApendResoltInTxtBox();
            }
            else
            {
                foreach(var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
        }
        
        void ApendResoltInTxtBox()
        {
            using (StreamReader sr = new StreamReader("base.xml"))
            {
                textBoxResult.Text = sr.ReadToEnd();
            }
        }

        public void serializToBase()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aircraft>), new Type[] { typeof(List<Member>), typeof(Member), typeof(Owner) });
            using (StreamWriter fs = new StreamWriter("base.xml", false))
            {
                xmlSerializer.Serialize(fs, AircraftMembers.aircrafts);
            }
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                type = ((RadioButton)sender).Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void toolStrip1_MouseLeave(object sender, EventArgs e)
        {
            if(!IsActiv)
                toolStrip1.Hide();
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            toolStrip1.Show();
        }

        public static bool IsActiv;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (IsActiv)
            {
                IsActiv = false;
                toolStripButton1.Text = "закрепить";
            }
            else
            {
                IsActiv = true;
                toolStripButton1.Text = "открепить";
            }
            toolStripButton1.Checked = IsActiv;

        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            Form formFind = new Form();
            formFind.Text = "Простой поиск";
            formFind.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            formFind.ClientSize = new System.Drawing.Size(430, 100);

            TextBox textBox = new TextBox();
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox.Location = new System.Drawing.Point(10, 12);
            textBox.Size = new System.Drawing.Size(350, 30);
            textBox.TextChanged += new EventHandler(textBox_TextChanged);

            Button buttonF = new Button();
            buttonF.Location = new Point(370, 12);
            buttonF.Text = "Найти";            
            buttonF.Size = new System.Drawing.Size(50, 30);
            buttonF.Click += new System.EventHandler(buttonF_Click);

            Button buttonSuperFind = new Button();
            buttonSuperFind.Location = new Point(10, 54);
            buttonSuperFind.Text = "Расширенный поиск";
            buttonSuperFind.Size = new System.Drawing.Size(410, 30);
            buttonSuperFind.Click += new System.EventHandler(buttonSuperFind_Click);

            formFind.Controls.Add(buttonSuperFind);
            formFind.Controls.Add(textBox);
            formFind.Controls.Add(buttonF);
            formFind.ShowDialog();
        }

        private void buttonSuperFind_Click(object sender, EventArgs e)
        {
            FormSuperF superF = new FormSuperF();
            superF.ShowDialog();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            string str = "";
            TextBox textBox = new TextBox();
            Form form = new Form();
            Regex regex = new Regex(" "+text+" ");

            foreach(var i in AircraftMembers.aircrafts)
            { 
                str = i.ToString();

                if (regex.IsMatch(str))
                    textBox.Text += str;                   
            }

            if (textBox.Text != "")
            {
                form.Text = "Результат поиска";
                textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                textBox.Location = new Point(10, 10);
                textBox.Size = new System.Drawing.Size(500, 400);
                textBox.Multiline = true;
                form.Size = new System.Drawing.Size(520, 420);
                form.Controls.Add(textBox);
                form.ShowDialog();
            }
            else
            {
                DialogResult result=MessageBox.Show(
                    "Совпадений не найдено, хотите ли воспользоваться расширенным поиском?",
                    "Результат поиска",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if(result== DialogResult.Yes)
                {
                    form.Dispose();
                    FormSuperF superF = new FormSuperF();
                    superF.ShowDialog();
                }
            }
        }

        public string text;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            text = ((TextBox)sender).Text;
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {           
            if (AircraftMembers.aircrafts.Count != 0)
            {
                
                string operation = ((ToolStripButton)sender).Text;
                string nameOfMessage = "Очистить всё";
                string message = "Вы точно хотите удалить все значения?";
                if(operation=="Удалить")
                {
                    nameOfMessage = "Удалить последний элемент";
                    message=("Вы точно хотите удалить последние значение?");
                }               

                DialogResult result = MessageBox.Show(
                        message,
                        nameOfMessage,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    File.Copy("base.xml", "copy.xml",true);

                    switch (operation)
                    {
                        case "Очистить":
                            AircraftMembers.aircrafts.Clear();
                            break;
                        case "Удалить":
                            AircraftMembers.aircrafts.RemoveAt(AircraftMembers.aircrafts.Count-1);
                            break;
                    }

                    serializToBase();
                    toolStripButtonBack.BackgroundImage= lab2.Properties.Resources.BackTrue;
                    IsBack = true;
                    toolStripStatusLabelCouner.Text = AircraftMembers.aircrafts.Count.ToString();
                    ApendResoltInTxtBox();

                }
            }
        }

        bool IsBack;
        bool IsNext;

        private void toolStripButtonSort_Click(object sender, EventArgs e)
        {
            FormSort formSort = new FormSort();
            formSort.ShowDialog();
        }

        private void toolStripButtonBackOrNext_Click(object sender, EventArgs e)
        {
            if (IsBack|| IsNext)
            {
                File.Move("base.xml", "baseToCopy.xml");
                File.Move("copy.xml", "base.xml");
                File.Delete("copy.xml");
                File.Move("baseToCopy.xml", "copy.xml");

                deserializeFromBase();
                ApendResoltInTxtBox();

                switch (((ToolStripButton)sender).Name)
                {
                    case "toolStripButtonBack":
                        {
                            toolStripButtonNext.BackgroundImage = lab2.Properties.Resources.NextTrue;
                            toolStripButtonBack.BackgroundImage = lab2.Properties.Resources.BackFalse;
                            IsBack = false;
                            IsNext = true;
                        }
                        break;
                    case "toolStripButtonNext":
                        {
                            toolStripButtonBack.BackgroundImage = lab2.Properties.Resources.BackTrue;
                            toolStripButtonNext.BackgroundImage = lab2.Properties.Resources.NextFalse;
                            IsBack = true;
                            IsNext = false;
                        }
                        break;
                }
            }
        }

        private void toolStripButtonInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия программы: лабораторная работа № 3\r\n Автор: Радчиков Артем","О программе");
        }
    }
}
