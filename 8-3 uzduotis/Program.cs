using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar norite skaiciuoti? t/n");
            var Pasirinkimas = Console.ReadLine();
           

            while (Pasirinkimas.ToLower() == "t")
            {
                Console.WriteLine("Iveskite pirmaji skaiciu");
                var Skaicius1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iveskite antraji skaiciu");
                var Skaicius2 = Convert.ToInt32(Console.ReadLine());

                //--------------------------------------------------------

                var Atsakymas = Skaicius1 + Skaicius2;
                Console.WriteLine("{0} + {1} = {2}",Skaicius1,Skaicius2,Atsakymas);

                Atsakymas = Skaicius1 - Skaicius2;
                Console.WriteLine("{0} - {1} = {2}", Skaicius1, Skaicius2, Atsakymas);

                Atsakymas = Skaicius1 * Skaicius2;
                Console.WriteLine("{0} * {1} = {2}", Skaicius1, Skaicius2, Atsakymas);

                Atsakymas = Skaicius1 / Skaicius2;
                Console.WriteLine("{0} / {1} = {2}", Skaicius1, Skaicius2, Atsakymas);
                
                //--------------------------------------------------------

                Console.WriteLine("Ar toliau norite skaiciuoti? t/n");
                Pasirinkimas = Console.ReadLine();
            }
        }
    }
}
