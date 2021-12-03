using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_tanımları
{
    class Program
    {
        static void Main(string[] args)
        {

            //    int a = 6, b = 8;
            //    Console.WriteLine(ToplamAl(a, b));
            //    saatkac();
            //    merhaba();


            //    Console.ReadLine();



            //}

            //private static void merhaba()
            //{
            //    Console.WriteLine("merhaba");
            //}

            //private static void saatkac()
            //{
            //    Console.WriteLine(DateTime.Now );
            //}

            //static int ToplamAl(int a ,int b)
            //{
            //    int sonuc = a + b;
            //    return sonuc;


            //    Console.WriteLine("1.sayıyı giriniz:");
            //    int sayi1 = Convert.ToInt32 (Console.ReadLine( ));

            //    Console.WriteLine("2.sayıyı giriniz:");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(carpım(sayi1, sayi2));
            //    Console.ReadLine(); 

            //}

            //private static int carpım(int sayi1, int sayi2)
            //{
            //    int sonuc = sayi1 * sayi2;
            //    return sonuc;




            //       Console.WriteLine("1.kenarı giriniz:");
            //       int kenar1 = Convert.ToInt32 (Console.ReadLine( ));

            //      Console.WriteLine("2.kenarıgiriniz:");
            //      int kenar2 = Convert.ToInt32(Console.ReadLine());

            //    alan(kenar1, kenar2);

            //    Console.ReadLine();



            //}

            //private static int alan(int kenar1,int kenar2)
            //{
            //   int alan = kenar1 * kenar2;




            //    switch (kenar1)
            //    {

            //        case int kontrol when kenar1 > kenar2 || kenar2>kenar1:
            //            Console.WriteLine($"dikdörtgenın alanı{kenar1*kenar2}"); 
            //            break;


            //        case int kontrol when kenar1 == kenar2:
            //            Console.WriteLine($"girdiğiniz deger karedır");
            //            break;

            //    }

            //    return alan;

             Console.WriteLine("1.açıyı giriniz:");
             int a = Convert.ToInt32 (Console.ReadLine( ));

             Console.WriteLine("2.açıyı giriniz:");
             int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.açıyı giriniz:");
            int c = Convert.ToInt32(Console.ReadLine());

            açıKontrol(a, b, c);
            Console.ReadLine();
        }

        private static  void açıKontrol(int a,int b,int c)
        {
             


            int sonuc = a + b + c;

            switch (sonuc)
            {
                case int kontrol when a==b && a==c && b==c:
                    Console.WriteLine("eşkenar üçgen");
                    break;
                case int kontrol when a == b && a!= c ||  b==c && a!=c: // a==b || a ==c || b==c
                    Console.WriteLine("ikizkenar üçgen");
                    break;
                default:
                    Console.WriteLine("çesitkenar üçgen");
                    break;
            }
            

        }
       

    }
}
