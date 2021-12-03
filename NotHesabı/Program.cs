using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotHesabı
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("1.notunuzu giriniz :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. notunuzu gırnız:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. notunuzu gırnız:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (s1 + s2 + s3) / 3;


            Console.WriteLine("ortalamanız: {0}", ortalama);
            Console.ReadLine();

           

                if (ortalama < 45)
                {
                    Console.WriteLine("  kaldınız ");
                }
                else if (ortalama < 45 && ortalama > 70)
                {
                    Console.WriteLine("  orta ");

                }
                else if (ortalama < 70 && ortalama > 85)
                {
                    Console.WriteLine(" iyi");

                }
                else if (ortalama < 70 && ortalama > 85)
                {
                    Console.WriteLine("Başarılı");
                }

                else if (ortalama > 100)
                {
                    Console.WriteLine("notlarınızı kontrol ediniz");

                }
                
            }

        }



       

    }

