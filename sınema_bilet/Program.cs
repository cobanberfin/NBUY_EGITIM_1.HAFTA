using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınema_bilet
{
    class Program
    {
        static int sayac;
        
        static string isimgelen = "";
        static int koltuksecim = 0;
        static int[] koltukNumarasi = {0, 1, 2, 3, 4, 5, 6, 7 };
        static string[] isimler = { "", "", "", "", "", "Ahmet", "", "" };
        static void Main(string[] args)
        {
            if (sayac ==0)
            {
                foreach (string item in isimler)
                {
                    if (item != "")
                    {
                        sayac++;
                    }

                }

            }

            if (sayac == isimler.Length)
            {
                Console.WriteLine("bilet alamazsınız");
                Console.ReadLine();
            }
            isimal();
            koltukkontrol();
            rezervasyon();
            Main(null);


            Console.ReadLine();


        }

       
        private static void isimal()
        {
            Console.WriteLine("LÜTFEN ADINIZI GİRİNİZ");
            isimgelen = Console.ReadLine();
            
            for(int i = 0; i < isimgelen.Length; i++)
            {
                if (char.IsDigit(isimgelen[i]))
                {
                    isimal();                                                                                      
                }
            }

        }
        private static void koltukkontrol()
        {
            
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] == "")
                {
                    Console.WriteLine($"{i}.koltuk boş");
                }
                else
                {
                    Console.WriteLine($"{i}. koltuk {isimler[i]}tarafından dolu");
                }
            }
            if (sayac == koltukNumarasi.Length)
            {
                Console.WriteLine("salon dolu");
            }
 
            else if(sayac != koltukNumarasi.Length)
            {
                Console.WriteLine("salon boş");
            }
        }
        private static void rezervasyon()
        {
            try
            {
                Console.WriteLine("istediğiniz koltuğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());

                if (isimler[koltuksecim] == "")
                {
                   
                    isimler[koltuksecim] = isimgelen;
                    sayac++;
                   
                }
                else
                {
                    Console.WriteLine("seçtiğiniz koltuk dolu");
                    rezervasyon();
                }
                Console.WriteLine($"{koltukNumarasi[koltuksecim]}numaralı koltuk{isimler[koltuksecim]}kişi tarafından rezerve edılmiştir");
                koltukkontrol();
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("olmayan koltuk seçtiniz !!!!");
                rezervasyon();
            }

            Console.ReadLine();
        }

       
    }

}
