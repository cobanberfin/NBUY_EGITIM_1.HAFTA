using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("adınız:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınız:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("şehriniz:");
            //string sehir= Console.ReadLine();
            //Console.Clear();


            //Console.WriteLine("1.sayıyı giriniz :");
            //string s = Console.ReadLine();
            //int s1 = Convert.ToInt32(s);
            //Console.WriteLine( "2. sayıyı gırnız:");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(s1+s2);

            //Console.Clear();

            //Console.WriteLine("yaşınızı giriniz:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //int yas1 =int.Parse(Console.ReadLine());





            //Console.ReadLine();


            // soru  string değeri bool tipine dönüştür

            string metin = "false";
            bool bm = Convert.ToBoolean(metin);
            bool pm = bool.Parse(metin);
           




            // soru int değeri 100 olandeğeri byte ve floata dönüştür
           
             int val1 = 100;
            float val2 = val1;
            byte val3 = (byte)val1;


            //  soru 3 byte ı decimale dönüştür

            byte a = 225;
            decimal de = Convert.ToDecimal(a);
            decimal de2 = a ;













        }
    }
}
