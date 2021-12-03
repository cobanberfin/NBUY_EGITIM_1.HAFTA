using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region case

            //Console.WriteLine("bir sayı gırınız:");
            //string deger = Console.ReadLine();



            //switch (deger)
            //{
            //    case "1":
            //        Console.WriteLine("ocak");
            //        break;

            //    case "2":
            //        Console.WriteLine("şubat");
            //        break;

            //    case "3":
            //        Console.WriteLine("mart");
            //        break;

            //    case "4":
            //        Console.WriteLine("nisan");
            //        break;

            //    case "5":
            //        Console.WriteLine("mayıs");
            //        break;

            //    case "6":
            //        Console.WriteLine("haziran");
            //        break;

            //    case "7":
            //        Console.WriteLine("temmuz");
            //        break;


            //    case "8":
            //        Console.WriteLine("ağustos");
            //        break;
            //    case "9":
            //        Console.WriteLine("eylül");
            //        break;

            //    case "10":
            //        Console.WriteLine("ekim ");
            //        break;

            //    case "11":
            //        Console.WriteLine("kasım");
            //        break;

            //    case "12":
            //        Console.WriteLine("aralık");
            //        break;

            //    default:
            //        Console.WriteLine("ay sayısından faszla değer");
            //        break;
            //}

            #endregion


            int sayi1, sayi2;
            string sec;
            Console.Write("1. Sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Sayıların Toplamı (1)");
            Console.WriteLine("Sayıların Farkı   (2)");
            Console.WriteLine("Sayıların Çarpımı (3)");
            Console.WriteLine("Sayıların Bölümü  (4)");
             
            Console.Write("Seçiminizi Yapınız: ");
            sec = Console.ReadLine();

         

            switch (sec)
            {
                case "1":
                    int toplam = sayi1 + sayi2;
                    Console.Write("İki sayının Toplamı: " + toplam);
                    break;
                case "2":
                    int fark = sayi1 - sayi2;
                    Console.Write("İki sayının Farkı: " + fark);
                    break;
                case "3":
                    int carpim = sayi1 * sayi2;
                    Console.Write("İki sayının Çarpımı: " + carpim);
                    break;
                case "4":
                    
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("girdiğiniz değeri kontrol ediniz");
                        }
                        else if (sayi2!=0)
                        {
                            int bolum = sayi1 / sayi2;
                            Console.Write("İki sayının Bölümü: " + bolum);
                            
                        }
                    break;

                default:
                    Console.Write("Lütfen 1-4 arasında bir sayı giriniz.");
                    break;
            }
            Console.ReadLine();











        }
    }
}





























