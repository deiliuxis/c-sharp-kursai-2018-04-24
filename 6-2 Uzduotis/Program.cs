using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite koki norite kompiuteri: 1-stacionarus    2-nesiojamas      3-plancete");

            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (Pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote stacionaru kompiuteri");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote nesiojama kompiuteri");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote plancete");
                    break;
                default:
                    Console.WriteLine("Neteisinga ivestis");
                    break;
            }
        }
    }
}
