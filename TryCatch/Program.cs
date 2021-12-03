using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("sayı giriniz");
                int s = Convert.ToInt32(Console.ReadLine());

                if (s == 10)
                {
                    throw new ozelhata();
                }
              //  Console.ReadLine();
            }
            catch (ozelhata fx)
            {
                Console.WriteLine("özel hata cllasındakı metot çalıştı");
            }
            catch (FormatException)
            {
                Console.WriteLine("hatalı format");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("doğru formatta girmedınız");


            }
            finally
            {
                //try bloğu çalışır
                //catch çalışır
                //finally her kosulda çalışır
                Console.WriteLine("finally bloğu çalıştı");
            }




            Console.ReadLine();
















            //try
            //{
            //    Console.WriteLine("alfabeden bir harf giriniz");
            //    char harf = Convert.ToChar(Console.ReadLine());

            //    if (harf == 'b')
            //    {
            //        throw new ozelhata();
            //    }
            //    Console.ReadLine();
            //}
            //catch(ozelhata fx)
            //{
            //   Console.WriteLine("özel hata cllasındakı metot çalıştı");

            //}


            //Console.ReadLine();
        }
    }
}
