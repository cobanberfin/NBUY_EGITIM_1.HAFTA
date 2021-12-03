using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string__yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            /****** REPLACE ******/

            //string cumle = "merhaba ayse ";
            //string yenıcumle = cumle.Replace("merhaba", "nasılsın"); Console.WriteLine(yenıcumle);


            /********  REMOVE *******/

            //string cumle = "merhaba ayse ";
            //string yenıcumle = cumle.Remove(0,3); 
            //Console.WriteLine(yenıcumle);

            /**********SUBSTRİNG *********/


            //string cumle = "merhaba ayse ";
            //string yenıcumle = cumle.Substring(0,6);
            //Console.WriteLine(yenıcumle);

            /*************** TRİM ************sag ve sol boşluğu siliyor*    */


            string cumle = "      merhaba ayse           ";
            string yenıcumle = cumle.Trim();
            Console.WriteLine(yenıcumle);



















            Console.ReadLine();

        }
    }
}
