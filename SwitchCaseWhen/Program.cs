using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseWhen
{
    class Program
    {
        static void Main(string[] args)
        {
            int yıl,yas;
             yenidenbaşla:
            Console.Write("doğum yılı giriniz: ");
            yıl = Convert.ToInt32(Console.ReadLine());

            yas = DateTime.Now.Year - yıl;
            // Console.WriteLine(yas);

            switch (yas)
            {
                case   int kontrol when yas>18:
                    Console.WriteLine($"yasınız {yas} ehlıyet alabilirsiniz");

                    break;

                case int kontrol when yas < 18:
                    Console.WriteLine($"yasınız{yas}ehliyet alamazsınız");
                    goto yenidenbaşla;

                default:
                    break;
            }





            Console.ReadLine( );

        }
    }
}
