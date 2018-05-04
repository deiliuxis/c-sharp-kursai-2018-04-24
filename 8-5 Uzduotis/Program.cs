using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Isvekiste skaiciu: ");
            var Skaicius = Convert.ToInt32(Console.ReadLine());
           

            while (Skaicius % 9 != 0)
            {
                Console.Write("Isvekiste skaiciu: ");
                Skaicius = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("Ivedete skaiciu kuris dalinasi is 9 :)))))))))))))");
        }
    }
}
