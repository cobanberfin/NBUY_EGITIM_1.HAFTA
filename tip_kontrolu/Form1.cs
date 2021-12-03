using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Type tip = sender.GetType();
            MessageBox.Show($"gelen nesnenın türü {tip}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool tip= sender.GetType()==typeof(Button);
            MessageBox.Show($"gelen değer {tip}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool deger = sender is Button;
            if (deger)
            {
                MessageBox.Show($"gelen nesnenın türü Button");
            }
            
        }
    }
}
