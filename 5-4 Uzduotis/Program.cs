using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 savo pazymius");

            var Pazymiai1 = Convert.ToInt32(Console.ReadLine());
            var Pazymiai2 = Convert.ToInt32(Console.ReadLine());
            var Pazymiai3 = Convert.ToInt32(Console.ReadLine());
            var Pazymiai4 = Convert.ToInt32(Console.ReadLine());
            var Pazymiai5 = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (Pazymiai1 + Pazymiai2 + Pazymiai3 + Pazymiai4 + Pazymiai5) / 5;

            if (vidurkis >= 5)
            {
                Console.WriteLine("Vidurkis daugiau nei 5");
            }
        }
    }
}
