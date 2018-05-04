using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 2 skaicius");

            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());

            if (Pirmas > Antras || Pirmas == 0)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antraji arba lygus nuliui");
            }

            if (Antras > Pirmas || Antras == 5)
            {
                Console.WriteLine("Antras skaicius didesnis uz pirmaji arba lygus 5");

            }

            if (Pirmas > Antras && Pirmas == 20)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antraji ir lygus 20");

            }

            if (Antras > Pirmas && Antras < 100)
            {
                Console.WriteLine("Antras skaicius didesnis uz pirmaji ir mazesnis uz 100");

            }
            
        }
    }
}
