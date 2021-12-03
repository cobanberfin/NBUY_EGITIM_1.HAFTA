using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dgmTarihi = dateTimePicker1.Value;
            TimeSpan Kacgungecti = DateTime.Now.Subtract(dgmTarihi);

            DateTime Yas = DateTime.MinValue + Kacgungecti;
            //min value 01.01.0001 degerını getırır.
            int yil = Yas.Year - 1;
            int ay = Yas.Month - 1;
            int gun = Yas.Day - 1;
            int yassiniri =Convert.ToInt32( textBox2.Text);
            string yasi = yil + "yıl";
            yasi += ay > 0 ? ay + "ay" : string.Empty;
            yasi += gun> 0 ? gun+ "gün" : string.Empty;

            if (yil > yassiniri)
            {
                MessageBox.Show(textBox1.Text + "yaşınız : " + yasi +"tutuyor",Environment.UserName,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(textBox1.Text + "yaşınız:" + yasi + "tutmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
