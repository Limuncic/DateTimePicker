using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeRafael
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;

            richTextBox1.AppendText("Vaš datum leta je: \r\n"+dt1.ToShortDateString() + "\r\n");
            richTextBox1.AppendText("Vaše vrijeme leta je: \r\n" + dt2.ToShortTimeString() + "\r\n");

        }
    }
}
