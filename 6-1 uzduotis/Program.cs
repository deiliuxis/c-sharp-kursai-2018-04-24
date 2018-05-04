using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite koki norite gerima: 1-vanduo    2-kava      3-arbata");

            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (Pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("Ivedete ne ta skaiciu");
                    break;
            }
        }
    }
}
