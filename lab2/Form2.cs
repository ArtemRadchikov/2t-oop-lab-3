using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBarExp.Value.ToString();
        }

        public void textBoxEmpty_Validating(object sender, EventArgs e)
        {
            // private void textBoxEmpty_Validating(object sender, CancelEventArgs e) 
            // Заменить оператор throw в обработчике события 
            // приводим тип 
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0 || tb.Text.Split(' ').Length!=3)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                this.buttonOK.Enabled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Member newMember = new Member(this.textBoxFIO.Text, this.labelPosition.Text, 
                                                            (int)this.upDownAge.Value, this.trackBarExp.Value);
            AircraftMembers.members.Add(newMember);
            AircraftMembers.IsOk = true;
            this.Dispose();
        }
    }
}
