using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Overload");
            MessageBox.Show("3.Overload", "merhaba");
            MessageBox.Show("5.Overload", "merhaba", MessageBoxButtons.YesNoCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7.overload", "merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            MessageBox.Show("bilgi", "merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult basilan = MessageBox.Show("yazılan metın", "merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);
            string mesaj = null;
            switch (basilan)
            {
                case DialogResult.Cancel:
                    mesaj = "iptal";
                    break;
                case DialogResult.No:
                    mesaj = "hayır";
                    break;
                case DialogResult.Yes:
                    mesaj = "evet";
                    break;
               
            }
            MessageBox.Show($"{mesaj}tuşuna bastınız");
        }
    }
}
