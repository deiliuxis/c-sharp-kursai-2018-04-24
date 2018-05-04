using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pasirinkimas;

            do
            {
                Console.WriteLine("Pasirinkite gyvuneli: 1-Suo  2-Kate   3-Kurmis");
                Pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (Pasirinkimas > 3 || Pasirinkimas < 1)
                {
                    Console.WriteLine("Pasirinkote ne ta skaiciuka");
                }

            } while (Pasirinkimas > 3 || Pasirinkimas < 1);

            Console.WriteLine("Jus pasirinkote: " + Pasirinkimas);
        }
    }
}
