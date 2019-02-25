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
    public partial class Form3 : Form
    {
    public Form3()
        {

            InitializeComponent();
            AutoCompleteStringCollection Comp = new AutoCompleteStringCollection(){"Aerospatiale/Alenia","Airbus S.A.S.", "Bell/Agusta Aerospace Company","Boeing","Bombardier Aerospace","British Aerospace","British Aircraft Corporation","Britten-Norman","Cessna Aircraft","Czech Aircraft Works",
            "Dassault Aviation","De Havilland","De Havilland Canada","EADS Socata","Embraer (Empresa Brasileira de Aeronautica) S.A.","Fairchild-Dornier","Fokker","GROB Aerospace","Gulf Aircraft Partnership (GAP)",
            "Gulfstream Aerospace Corporation","Harbin Aircraft Manufacturing Corporation","Israel Aircraft","Kestrel Aircraft","Lancair","Let Aircraft Industries","Lockheed Corporation","McDonnell Douglas","Saab",
            "Vickers","Xi'an Aircraft Industrial Corporation","Англо-французский консорциум BAC-SNIAS","Гражданские самолеты Сухого","МышМашАвиа","Нижегородский авиационный завод","ОКБ А.Н.Туполева",
            "ОКБ А.С. Яковлева","ОКБ Г.М. Бериева","ОКБ О.К.Антонова","ОКБ С.В. Ильюшина"};
            textBox1.AutoCompleteCustomSource = Comp;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string value = "";
            foreach(var i in checkedListBox1.CheckedItems)
            {
                value += i.ToString()+" ";
            }
            AircraftMembers.form3Owner = new Owner(textBox1.Text, comboBox1.Text, (int)Year.Value, value.Split(' '));
            this.Dispose();

        }
        public void textBoxEmpty_Validating(object sender, EventArgs e)
        {
            // private void textBoxEmpty_Validating(object sender, CancelEventArgs e) 
            // Заменить оператор throw в обработчике события 
            // приводим тип 
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0 )
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
    }
}
