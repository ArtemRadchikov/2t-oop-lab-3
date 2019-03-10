using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace lab2
{
    public partial class FormSort : Form
    {
        public FormSort()
        {
            InitializeComponent();
        }       

        private void buttonSortFio_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("base.xml");
            XElement root = xdoc.Element("ArrayOfAircraft");

            var list=root.Elements("Aircraft").ToList();

            var sortedList=list.OrderBy(i => {
                if (i.Element("Members").Element("Member").Element("Prof").Value == "Капитан")
                    return i.Element("Members").Element("Member").Element("Fio").Value;
                else
                    return null;
                    });

            textBoxResult.Text = "Значения элементо Fio в отсортированном списке:\r\n";
            foreach (var i in sortedList)
            {
                textBoxResult.Text += i.Element("Members").Element("Member").Element("Fio").ToString()+"\r\n";
            }

            using (StreamWriter sw = new StreamWriter("Sorted list by FIO.xml", false))
            {
                foreach(var i in sortedList)
                {
                    sw.WriteLine(i);
                }
            }
        }

        private void buttonSortDate_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("base.xml");
            XElement root = xdoc.Element("ArrayOfAircraft");
            
            var list = root.Elements("Aircraft").ToList();
            var sortedList = list.OrderByDescending(i => DateTime.Parse(i.Element("DateService").Value));

            textBoxResult.Text = "Значения элементо DateService в отсортированном списке:\r\n";
            foreach (var i in sortedList)
            {
                textBoxResult.Text += i.Element("DateService").ToString() + "\r\n";
            }

            using (StreamWriter sw = new StreamWriter("Sorted list by Date.xml", false))
            {
                foreach (var i in sortedList)
                {
                    sw.WriteLine(i);
                }
            }
        }
    }
}
