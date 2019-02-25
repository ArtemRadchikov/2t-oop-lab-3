using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;

namespace lab2
{
    public partial class Form1 : Form
    {
        public string type;

        public Form1()
        {
            InitializeComponent();
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
            MessageBox.Show(aircraft.ToString());

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Aircraft), new Type[] { typeof(List<Member>), typeof(Member), typeof(Owner) });

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Aircraft), new Type[] { typeof(List<Member>), typeof(Member), typeof(Owner)});
            using (StreamWriter fs = new StreamWriter("base.txt", true))
            {
                // jsonSerializer.WriteObject(fs, aircraft);   
                xmlSerializer.Serialize(fs, aircraft);
            }
            AircraftMembers.members.RemoveAll(i=>true);
            AircraftMembers.form3Owner = null;
            checkedListBox1.ClearSelected();
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
    }
}
