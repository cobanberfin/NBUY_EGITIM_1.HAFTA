using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[7, 3]
            {
                { "istanbul","çanakkale","bursa"},
                { "izmir","manisa","muğla"},
                { "antalya","ısparta","mersin"},
                { "konya","ankara","eskişehir"},
                { "zonguldak","trabzon","rize"},
                { "gaziantep","mardin","urfa"},
                { "ağrı","hakkari","van"}
            };


                  //en yuksek değer kadar don
            for( int i=0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j<= bolgeler.GetUpperBound(1) ; j++)
                {
                    Console.WriteLine(bolgeler[i, j]);
                }
                Console.WriteLine("*************");
            }
            Console.ReadLine();

        }
    }
}
