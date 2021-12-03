using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OUT
            //int a = 50, b = 40, max;
            //buyukgetir(a,b,out max);
            //Console.WriteLine($"sayıların en büyüğü: {max}");



            //    string metin1 = "bilgisayar", metin2 = "klavye";

            //    uzunugetir(metin1, metin2, out int max);
            //    Console.WriteLine($"uzun olan metin uzunluğu :{max}");

            //    Console.ReadLine();
            //}

            //private static void uzunugetir(string a, string b, out int  x)
            //{
            //    if (a.Length > b.Length)
            //    {
            //       x = a.Length;

            //    }
            //    else
            //    {
            //       x = b.Length;
            //    }
            //}

            //private static void buyukgetir(int a, int b, out int max)
            //{
            //    if(a>b)

            //        max = a;
            //        else
            //            max = b;



            //    int x = 5, c;
            //    Console.WriteLine("sayı:"+x);
            //    Console.WriteLine("sayının karesi :"+kare(x,out c));
            //    Console.WriteLine("sayının küpü :"+c);
            //    Console.ReadLine();



            //}
            //private static int kare(int a ,out int y)
            //{
            //    int k;
            //    k = a * a;
            //    y = a * a * a;
            //    return k;

            //}
            #endregion

            int x = 20, y = 10;
            degistir(ref x, ref y);

            Console.WriteLine($"x in yenı degeri={x}");
            Console.WriteLine($"y in yenı degeri={y}");
            Console.ReadLine();

        }

        private static void degistir(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
        }
    }
}
