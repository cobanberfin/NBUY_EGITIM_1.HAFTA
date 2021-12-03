using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for
            //int toplam = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }



            //}
            //Console.WriteLine("çift sayıların toplamı{0}", toplam);



            ////alfabe yazalım
            //for (char i = 'Z'; i >= 'A'; i--)
            //{
            //    Console.WriteLine(i);
            //}



            //for (int i = 100; i >= 1; i -= 4)
            //{
            //    Console.WriteLine(i);
            //}
            //int sayi = 0;
            //int sonuc = 1;
            //Console.WriteLine("sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc = sonuc * i;
            //}

            //Console.WriteLine(sonuc);






            //int toplam = 0;
            //int sayi;

            //Console.Write("Adet sayisini giriniz: ");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < adet; i++)
            //{

            //    Console.Write("Sayi giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            //Console.WriteLine("Sayiların ortsı= " + (toplam / adet));


            #endregion


            #region iç içe for döngüsü


            //for (int i=1; i <= 4; i++)
            //{
            //    for(int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}


            //*****
            // ****
            // ***
            //**
            //*

            //for(int i=5; i>=1; i--)
            //{
            //    for ( int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();




            //Console.WriteLine("eni giriniz");
            //int e = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("boyu giriniz");
            //int b = Convert.ToInt32(Console.ReadLine());


            //for(int i =1;i<=b; i++)
            //{


            //    for (int j=1;j<=e;j++)
            //    {
            //        Console.Write("*");



            //    }

            //    Console.WriteLine();
            //}
            //if (e == b)
            //{
            //    Console.WriteLine("kare çizdirdiniz");
            //}



            //for(int a =1; a <= 10; a++)
            //{
            //    for(int b = 1; b <= 10; b++)
            //    {
            //       // Console.Write("{0}x{1}={2}	",a,b, (b * a));
            //        Console.WriteLine($"{a}x{b}={a*b}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //Console.ReadLine();

            int sayac = 0;
            for (int i = 1; i <= 10; i++)
            { sayac++;
                Console.WriteLine("mesajınız alındı");
                if (sayac == 5)
                {
                    break;
                }
            }
            Console.ReadLine();

        }


    }

}

