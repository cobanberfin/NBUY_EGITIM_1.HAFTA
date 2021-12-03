using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uçakbıleti
{
    class Program
    {


        static int koltuksecim = 0;
        static string[] economy = { "", "", "", "", "", "", "", "" };
        static string[] business = { "", "", "", "", "", "", "", "", "", "", "", "" };
        static string isim, tus;


        static void Main(string[] args)
        {

            AnaMenu();
            isimal();
            koltukkontrol();
            rezervasyon();
            Main(null);
            Console.ReadLine();

            #region benım


            //    Console.WriteLine("lütfen seçim yapınız(Bussines Class bölümü için->1/Economy Class bölümü için->2)");
            //    int tus = Convert.ToInt32(Console.ReadLine());


            //    if (tus == 1)
            //    {
            //        isimal();
            //    }



            //    //anaMenu();
            //    isimal();
            //    koltukkontrol();
            //      rezervasyon();






            //}
            //private static void isimal()
            //{
            //    Console.WriteLine("isminizi girniz");
            //    string isim = Console.ReadLine();

            //    for (int i = 0; i < isim.Length; i++)
            //    {
            //        if (char.IsDigit(isim[i]))
            //        {
            //            isimal();
            //        }
            //    }
            //    koltukkontrol();

            //}

            //private static void koltukkontrol()
            //{

            //    for (int i = 0; i < economy.Length; i++)
            //    {
            //        if (economy[i] == "")
            //        {
            //            Console.WriteLine($"{i}.koltuk boş");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{i}. koltuk {economy[i]}tarafından dolu");
            //        }
            //    }
            //    rezervasyon();

            //}
            //private static void rezervasyon()
            //{


            //        Console.WriteLine("istediğiniz koltuğu seçiniz");
            //        koltuksecim = Convert.ToInt32(Console.ReadLine());

            //        if (economy[koltuksecim] == "")
            //        {

            //            economy[koltuksecim] = isim;


            //        }
            //        else
            //        {
            //            Console.WriteLine("seçtiğiniz koltuk dolu");
            //            rezervasyon();
            //        }


            //        rezervasyon();

            //    Console.ReadLine();
            #endregion
        }


        private static void AnaMenu()
        {
            Console.WriteLine("1.Business Class bölümü için 1 tuşuna basınız");
            Console.WriteLine("1.Economy Class bölümü için 2 tuşuna basınız");
            tus = Console.ReadLine();
            switch (tus)
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("secim yap");
                    AnaMenu();
                    break;
            }
        }


        private static void isimal()
        {
            Console.WriteLine("ad");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {

                if (char.IsDigit(isim[i]))
                {
                    Console.WriteLine("lütfen sayısal karakter girmeyiniz");
                    isimal();
                }
            }
        }

        private static void koltukkontrol()
        {
            int sayac = 0;
            if (tus == "1")
            {
                for (int i = 0; i < business.Length; i++)
                {
                    if (business[i] == "")
                    {
                        Console.WriteLine($"{i}numaralı koltuk bos");
                    }
                    else
                    {
                        Console.WriteLine($"{i}numaralı koltuk dolu");

                    }
                }

                if (sayac == business.Length)
                {
                    Console.WriteLine("uçağımız dolmuştur");
                }
                else if (sayac != business.Length)
                {
                    Console.WriteLine("yerimiz mevcuttur");
                }
            }

            else if (tus == "2")
            {
                for (int i = 0; i < economy.Length; i++)
                    if (economy[i] == "")
                    {
                        Console.WriteLine($"{i}numaralı koltuk boştur");

                    }
                    else
                    {
                        Console.WriteLine($"{i}numaralı koltuk doludur");

                    }
            }

            if (sayac == economy.Length)
            {
                Console.WriteLine("uçağımız dolmuştur");

            }
            else if(sayac != economy.Length) {
                Console.WriteLine("yerimiz mevcuttur");
            }



        }

        private static void rezervasyon()
        {
            if (tus == "1")
            {
                Console.WriteLine("istediğiniz koltugu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());
                if (business[koltuksecim] == "")
                {
                    business[koltuksecim] = isim;
                }
                else
                {
                    Console.WriteLine($"{koltuksecim}numaralı koltuk daha önce {business [koltuksecim]}tarafından rezerve edilmiştir.Boş koltuklardan seçiniz");
                    rezervasyon();
                }
                Console.WriteLine($"{koltuksecim} numaralı koltuk{business[koltuksecim]} tarafından rezerve edılmıştır");
                koltukkontrol();
            }

            else if (tus == "2")
            {
                Console.WriteLine("istediğiniz koltugu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());
                if (business[koltuksecim] == "")
                {
                    business[koltuksecim] = isim;
                }
                else
                {
                    Console.WriteLine($"{koltuksecim}numaralı koltuk daha önce {business[koltuksecim]}tarafından rezerve edilmiştir.Boş koltuklardan seçiniz");
                    rezervasyon();
                }
                Console.WriteLine($"{koltuksecim} numaralı koltuk{business[koltuksecim]} tarafından rezerve edılmıştır");
                koltukkontrol();

            }
           
            //busıns clas tamamen doldugunda bıtsın yada ekonımıden secsin hangısı boşsa         
        }
    }
} 

