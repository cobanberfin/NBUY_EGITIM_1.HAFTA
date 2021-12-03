using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "pzt", "salı", "çrşba", "prşmbe", "cuma", "cmrts", "pazar" };
            string[] aylar = { "ocak", "şubat", "mart", "nisan", "mayıs", "hazrn", "temmuz" };

            foreach (string item in gunler)
            {
               comboBox1.Items.Add(item);
            }

            Aylar.Items.AddRange(aylar);
            foreach (Control ctr in Controls )
            {
                ctr.BackColor = Color.CadetBlue;
                ctr.ForeColor = Color.Bisque;

            }
        }
    }
}
