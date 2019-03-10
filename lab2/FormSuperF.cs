using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab2
{
    public partial class FormSuperF : Form
    {
        public FormSuperF()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
            {
                string str;
                textBoxResult.Text = "";
                Regex regex = new Regex(@"Авиокомпания:\s[" + textBoxInput.Text + @"]", RegexOptions.IgnoreCase);

                foreach (var i in AircraftMembers.aircrafts)
                {
                    str = i.ToString();

                    if (regex.IsMatch(str))
                        textBoxResult.Text += str;
                }
                if (textBoxResult.Text == "")
                    textBoxResult.Text = "Совпадений не найдено";
            }
            else
                CollectionIntoBoxResult();
        }

        private void FormSuperF_Load(object sender, EventArgs e)
        {
            CollectionIntoBoxResult();
        }

        public void CollectionIntoBoxResult()
        {
            textBoxResult.Text = "";
            foreach (var i in AircraftMembers.aircrafts)
                textBoxResult.Text += i.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string range = ((Button)sender).Text;
            string str="";
            string pref;
            string fullText=textBoxResult.Text;
            bool Is56 = ((Button)sender).Name == "button5" || ((Button)sender).Name == "button6";
            switch (range)
            {
                
                case "50-99":
                        str = @"\s[5-9]\d\s";
                    break;
                case "100-149":
                        str = @"\s[1][0-4]\d\s";
                    break;
                case "150-199":
                        str = @"\s[1][5-9]\d\s";
                    break;
                default:
                        str = @"\s[1-4]?\d\s";
                    break;
            }
            //Regex regex = new Regex(@"тип:" + str);
            if (Is56)
                pref = @"грузоподъемность:";
            else
                pref = @"кол-во мест:";

            matchCollection = Regex.Matches(textBoxResult.Text, pref + str,RegexOptions.Multiline);

            if (matchCollection.Count != 0)
            {
                if (matchCollection.Count > 1)
                {
                    buttonPrev1.Visible = true;
                    buttonNext1.Visible = true;
                }
                else
                {
                    buttonPrev1.Visible = false;
                    buttonNext1.Visible = false;
                }
                if (Is56)
                {
                    labelDiapazon.Text = "Диапазон"+"(г/п):"+ range;
                }
                else
                    labelDiapazon.Text = "Диапазон" + "(к/м):" + range;

                labelDiapazon.Visible = true;

                CounterButtons1 = 0;
                textBoxResult.SelectionStart = matchCollection[CounterButtons1].Index;
                textBoxResult.SelectionLength = matchCollection[CounterButtons1].Length;
                textBoxResult.Focus();
            }
            else
            {
                MessageBox.Show("Совпадений не найдено", "Результат поиска");
                MatchCollection matchCollection = null;
            }
        }
                
        MatchCollection matchCollection;
        int CounterButtons1;

        private void buttons_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            int iterator=1;
            switch(name)
            {
                case "buttonPrev1": iterator = -1;
                    break;
                case "buttonNext1": iterator = 1;
                    break;
            }

            CounterButtons1 += iterator;
            if (CounterButtons1 >= matchCollection.Count)
                CounterButtons1 = 0;
            if(CounterButtons1 <0)
                CounterButtons1 = matchCollection.Count-1;

            textBoxResult.SelectionStart = matchCollection[CounterButtons1].Index;
            textBoxResult.SelectionLength = matchCollection[CounterButtons1].Length;
            textBoxResult.Focus();

        }
    }
}
