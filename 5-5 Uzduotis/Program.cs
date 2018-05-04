using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");

            var Skaicius1 = Convert.ToInt32(Console.ReadLine());
            var Skaicius2 = Convert.ToInt32(Console.ReadLine());
            var Skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (Skaicius1 > Skaicius2)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra");
            }
            else if (Skaicius2 > Skaicius3)
            {
                Console.WriteLine("antras skaicius didesnis uz trecia");
            }
            else if (Skaicius3 > Skaicius1)
            {
                Console.WriteLine("trecias skaicius didesnis uz pirma");
            }
            else if (Skaicius1 == Skaicius2)
            {
                Console.WriteLine("pirmas skaicius lygus antram");
            }

        }
    }
}
