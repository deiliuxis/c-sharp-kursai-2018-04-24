using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prasome ivesti 3 skaicius");

            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            if (Pirmas < Antras && Pirmas < Trecias)
            {
                Console.WriteLine("Pirmas skaicius maziausias");
            }
            else if (Antras < Pirmas && Antras < Trecias)
            {
                Console.WriteLine("Antras skaicius maziausias");
            }
            else if (Trecias < Antras && Trecias < Antras)
            {
                Console.WriteLine("Trecias skaicius maziausias");
            }
        }
    }
}
