using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePickerKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            DateTime datum = dateTimePicker1.Value;

            DateTime vrijeme = dateTimePicker2.Value;

            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Datum vašeg leta je: ");

            sb1.Append(datum.ToShortDateString() + "\n");

            sb1.Append("Vrijeme vaseg polaska je: ");

            sb1.Append(vrijeme.ToShortTimeString());

            richTextBox1.AppendText(sb1.ToString());

        }
    }
}
