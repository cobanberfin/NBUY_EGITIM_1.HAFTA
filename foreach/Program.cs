using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isim = { "Eda", "selin", "salih", "ayşe","lale" };

            //foreach (string item in isim )
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadLine();



            #region while




            //int sayac =5;
            //int şifre = 1234;
            //while (sayac>0)
            //{
            //    Console.WriteLine("şifre girin");
            // int s = Convert.ToInt32(Console.ReadLine());

            //        sayac--;
            //    if (s == şifre)
            //    {
            //        Console.WriteLine("giriş başarılı");
            //        break;

            //    }

            //    else if(şifre !=s)
            //    {
            //        Console.WriteLine($"kalan hakkınız:{sayac}");
            //    }
            //    if (sayac == 0)
            //    {
            //        Console.WriteLine( "yanlış şifre girdiniz");
            //    }

            //}



            //Random sayiuret = new Random();
            //int uretilensayi = sayiuret.Next(1, 10);
            //int tahmin =1;
            //while (true)
            //{
            //    Console.WriteLine("tuttuğum sayı tahmın et :");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    tahmin++;

            //    if (uretilensayi == s)
            //    {
            //        Console.WriteLine($" {tahmin}. tahminde bildiniz");

            //    }
            //    else if(uretilensayi !=s)
            //        Console.WriteLine("bilemediniz");


            //}
            #endregion

            #region do while
            // int sayac = 1;
            //int çifttop=0;
            //int tektop=0;

            //do
            //{
            //    if (sayac % 2 == 0)
            //    {

            //        çifttop += sayac;


            //    }
            //    else if(sayac%2 !=0)
            //    {
            //        tektop += sayac;


            //    }

            //    Console.WriteLine(sayac % 2 == 0 ? sayac + ":çift" : sayac + ":Tek");
            //    sayac++;

            //}
            //while (sayac <= 100);
            //Console.WriteLine(çifttop);
            //Console.WriteLine(tektop);

            //// cift = sayac%2==0 ? cift+sayac:cift+0;
            //// tek = sayac%2!=0 ? tek+sayac:tek+0;

            //Console.ReadLine();





            #endregion
            #region dizi



            //string[] isim = { "ali", "demet", "seda" };
            //// dizi tanımlanır eleman sayısı bildirilir
            //int[] s = new int[5];
            ////eleman sayısı ve elemanlrı belirlenir
            //int[] a = new int[4] { 1, 2, 3, 4 };
            //// elemanların indekslerı ıle sonradan belirtir
            //int[] b = new int[2];
            //b[1] = 4;
            //b[0] = 5;
            //b[2] = 2;



            //foreach (int sayi in b)
            //{
            //    Console.WriteLine(sayi);

            //}
            ////forla dizi yazma
            //for( int i=0; i <= b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}
            #endregion



            //Console.WriteLine("kaç elemanlı dizi oluşturmak istersin");
            //int elemanS = Convert.ToInt32(Console.ReadLine());

            //int[] sayi = new int[elemanS];
            //int toplam = 0, ort = 0;
            //for(int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine($"{i}indeksine sayı gırnız");
            //    int eleman = Convert.ToInt32(Console.ReadLine());
            //    sayi[i] = eleman;
            //}
            //foreach (var item in sayi)
            //{
            //    Console.WriteLine(item);
            //    toplam = toplam + item;
            //}
            //Console.WriteLine($"sayıların toplamı{toplam}");
            //ort = toplam / sayi.Length;
            //Console.WriteLine($"sayıların ortalaması{ort}");




            // 20 elemanlı bır int dizisi oluşturalım.değerlerımızı random sınıfının next fonkile 1 ila 10 arasındas dolduralım daha sonra dizi içersindeki elemanları ekrana yazdır ve ilgii dizi içerisnde kaç tane 4 degerı var bulun


            // int[] k = new int[20];


            //for(int i=0; i < k.Length;i++)
            //{
            //    Random rastgele = new Random();
            //    int sayi = rastgele.Next(1, 10);

            //      k[i] =sayi;
            //    Console.WriteLine(sayi);

            //}
            //foreach (var item in k)
            //{
            //    Console.WriteLine(item);
            //}





            //int[] dizi = new int[20];
            //Random rnd = new Random();
            //int sayac = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(1, 10);
            //}

            //foreach (int item in dizi)
            //{
            //    Console.WriteLine(item);
            //    if (item == 4)
            //    {
            //        sayac++;
            //    }
            //}

            //Console.WriteLine($"{sayac}adet 4 bulundu");

            

            #region SAYISAL LOTO

            //int[] sayilar = new int[6];
            //Random rnd = new Random();

            //string sayi = "";
            //for(int i = 0; i < 6; i++)
            //{
            //    int sayiuret = rnd.Next(1, 50);
            //    if (!sayi.Contains(sayiuret.ToString()))
            //    {
            //        sayi = $"{sayiuret} {sayi}";
            //        sayilar[i] = sayiuret;
               
            //    }
            //}

            //Console.WriteLine(sayi);
            //Array.Sort(sayilar);
            //foreach (int item in sayilar)
            //{
            //    Console.Write(item+" ");
            //}

            //Console.ReadLine();
            #endregion














        }
    }
}
