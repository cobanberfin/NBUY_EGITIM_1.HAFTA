using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_Parola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soruno = 0, dogru, yanlis;
        string cevap = null;

        
       
        private void dogruArttı()
        {
            dogru++;
            label2.Text = dogru.ToString();
        }
        private void yanlısArttır()
        {
            yanlis++;
            label2.Text = yanlis.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cevap = textBox1.Text.ToLower();
                switch (soruno)
                {
                    case 1:
                        if (cevap == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;

                    case 2:
                        if (cevap == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 3:
                        if (cevap == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 4:
                        if (cevap == "Diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 5:
                        if (cevap == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 6:
                        if (cevap == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 7:
                        if (cevap == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 8:
                        if (cevap == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 9:
                        if (cevap == "Isparta")
                        {
                            button9.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 10:
                        if (cevap == "halı")
                        {
                            button10.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 11:
                        if (cevap == "bölük")
                        {
                            button11.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 12:
                        if (cevap == "halı")
                        {
                            button12.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 13:
                        if (cevap == "mart")
                        {
                            button13.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 14:
                        if (cevap == "ney")
                        {
                            button14.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 15:
                        if (cevap == "ozan")
                        {
                            button15.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 16:
                        if (cevap == "pırasa")
                        {
                            button16.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 17:
                        if (cevap == "ramazan")
                        {
                            button17.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 18:
                        if (cevap == "snake")
                        {
                            button18.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 19:
                        if (cevap == "tarkan")
                        {
                            button19.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 20:
                        if (cevap == "computer")
                        {
                            button20.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 21:
                        if (cevap == "van")
                        {
                            button21.BackColor = Color.Green;
                            dogruArttı();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;
                    case 22:
                        if (cevap == "kara")
                        {
                            button22.BackColor = Color.Green;
                            dogruArttı();
                        }


                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlısArttır();
                        }
                        break;



                    default:
                        break;
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruno++;
            textBox1.Clear();
            linkLabel1.Text = "SONRAKİ";
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmıdaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
                Harf.Text = button1.Text;
            }
            else if(soruno==2)
            {
                richTextBox1.Text = "yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;
                Harf.Text = button2.Text;
            }
            else if (soruno==3)
            {
                richTextBox1.Text = "müslümanların kutsal günü ?";
                button3.BackColor = Color.Yellow;
                Harf.Text = button3.Text;

            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "karpuzuyla ünlü ilimiz? ?";
                button4.BackColor = Color.Yellow;
                Harf.Text = button4.Text;

            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelımseının zıt anlamlısı ?";
                button5.BackColor = Color.Yellow;
                Harf.Text = button5.Text;

            }
            else if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                button6.BackColor = Color.Yellow;
                Harf.Text = button6.Text;

            }
            else if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                button7.BackColor = Color.Yellow;
                Harf.Text = button7.Text;

            }
            else if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne aldığı zaman baktığı yer?";
                button8.BackColor = Color.Yellow;
                Harf.Text = button8.Text;

            }
            else if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                button9.BackColor = Color.Yellow;
                Harf.Text = button9.Text;

            }
            else if (soruno == 10)
            {
                richTextBox1.Text = "Askeri bir topluluk  ?";
                button10.BackColor = Color.Yellow;
                Harf.Text = button10.Text;

            }
            else if (soruno == 11)
            {
                richTextBox1.Text = "Malatyanın meshur meyvesı ?";
                button11.BackColor = Color.Yellow;
                Harf.Text = button11.Text;

            }
            else if (soruno == 12)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlene cıcek festivali?";
                button12.BackColor = Color.Yellow;
                Harf.Text = button12.Text;

            }
            else if (soruno == 13)
            {
                richTextBox1.Text = "Yılın üçüncü ayı ?";
                button13.BackColor = Color.Yellow;
                Harf.Text = button13.Text;

            }
            else if (soruno == 14)
            {
                richTextBox1.Text = "üflemeli bir müzik aleti?";
                button14.BackColor = Color.Yellow;
                Harf.Text = button14.Text;

            }
            else if (soruno == 15)
            {
                richTextBox1.Text = "Halk Şairi ?";
                button15.BackColor = Color.Yellow;
                Harf.Text = button15.Text;

            }
            else if (soruno == 16)
            {
                richTextBox1.Text = "Çocukların sevmediği pirinç havuç gibi sebzelerden yapılan yemek?";
                button16.BackColor = Color.Yellow;
                Harf.Text = button16.Text;

            }
            else if (soruno ==17 )
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button17.BackColor = Color.Yellow;
                Harf.Text = button17.Text;

            }
            else if (soruno == 18)
            {
                richTextBox1.Text = "ingilizcede yılan ?";
                button18.BackColor = Color.Yellow;
                Harf.Text = button18.Text;

            }
            else if (soruno == 19)
            {
                richTextBox1.Text = "Türkiyenın mega starı?";
                button19.BackColor = Color.Yellow;
                Harf.Text = button19.Text;

            }
            else if (soruno == 20)
            {
                richTextBox1.Text = "ingilizcede bilgisayar  ?";
                button20.BackColor = Color.Yellow;
                Harf.Text = button20.Text;

            }
            else if (soruno == 21)
            {
                richTextBox1.Text = "kahvaltısı ile ünlü ilimiz ?";
                button21.BackColor = Color.Yellow;
                Harf.Text = button21.Text;

            }
            else if (soruno == 22)
            {
                richTextBox1.Text = "siyah kelımesını eş anlamlısı ?";
                button22.BackColor = Color.Yellow;
                Harf.Text = button22.Text;

            }
        }





        
    }
}
