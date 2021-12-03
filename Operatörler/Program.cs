using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim;


            Console.WriteLine("1.sayıyı giriniz :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı gırnız:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen secım yapınız (topla->1/çıkar->2 /böl->3/ çarp->4)");
            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                topla(s1, s2);
                Console.WriteLine(topla(s1, s2));

            }
            else if (secim == 2)
            {
                cıkar(s2, s1);
                Console.WriteLine(cıkar(s1, s2));
            }
            else if (secim == 3)
            {
                if (s2 != 0)
                {
                    böl(s1, s2);
                    Console.WriteLine(böl(s1, s2));


                }
                else
                {
                    Console.WriteLine("sıfırdan farklı deeğer giriniz");

                }
            }
            Console.ReadLine();
        }

       

                static int topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static int cıkar(int s1, int s2)
        {
            return s1 - s2;
        }
        static int böl(int s1, int s2)
        {
            return s1 / s2;
        }
        static int çarp(int s1, int s2)
        {
            return s1 * s2;
        }



    }

}
