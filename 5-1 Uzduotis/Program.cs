using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius sveikuosius");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            if (Pirmas == Antras)
            {
                Console.WriteLine("{0} = {1}", Pirmas, Antras);
            }

            if (Antras == Trecias)
            {
                Console.WriteLine("{0} = {1}", Antras, Trecias);
            }

            if (Pirmas > Antras)
            {
                Console.WriteLine("{0} > {1}", Pirmas, Antras);
            }

            if (Antras > 2 * Trecias)
            {
                Console.WriteLine("{0} > 2*{1}", Pirmas, Antras);
            }

            if (Pirmas % 2 == 0)
            {
                Console.WriteLine("{0} yra lyginis", Pirmas);
            }

            if (Antras % 2 != 0)
            {
                Console.WriteLine("{0} yra nelyginis", Antras);
            }

            if (Trecias > 0)
            {
                Console.WriteLine("{0} > 0", Trecias);
            }

            if (Trecias < 0)
            {
                Console.WriteLine("{0} < 0", Trecias);
            }
        }
    }
}
