using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti 3 skaicius");

            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            if (Pirmas > Antras && Pirmas > Trecias)
            {
                Console.WriteLine("Pirmas skaicius didziausias");
            }
            else if (Antras > Pirmas && Antras > Trecias)
            {
                Console.WriteLine("Antras skaicius didziausias");
            }
            else if (Trecias > Antras && Trecias > Antras)
            {
                Console.WriteLine("Trecias skaicius didziausias");
            }

        }
    }
}
