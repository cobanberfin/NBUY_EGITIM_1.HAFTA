using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte b1 = 125;
            int d = b1;
            MessageBox.Show(d.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d1 = 12.5;
            int i =(int)d1;
            MessageBox.Show("senin ilk halin " + d1 + "dönüşümden sonraki halin"+i);

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            string s = "123456";
            int s2 = Convert.ToInt32(s);
            MessageBox.Show(s2.ToString());

        }
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime("26/11/2021");
            MessageBox.Show(date.ToLongDateString() + "\n" + date.ToShortTimeString() + "\n" + date.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = "12345";
            int i = int.Parse(a);
            MessageBox.Show(i.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string h = "125";

            bool rakam = byte.TryParse(h, out byte sonuc);
            MessageBox.Show(sonuc.ToString());
        }
    }
}
