using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti 3 egzaminu rezultatus");

            var Pirmas = Convert.ToInt32(Console.ReadLine());
            var Antras = Convert.ToInt32(Console.ReadLine());
            var Trecias = Convert.ToInt32(Console.ReadLine());

            var Vidurkis = Math.Round((double)(Pirmas + Antras + Trecias) / 3, 5);

            if (Vidurkis >= 8 && Vidurkis <= 10)
            {
                Console.WriteLine("Jusu vidurkis tarp 8 ir 10");
            }

            else if (Vidurkis >= 5 && Vidurkis < 8)
            {
                Console.WriteLine("Jusu vidurkis tarp 5 ir 8");
            }
            else if (Vidurkis < 5)
            {
                Console.WriteLine("Jusu vidurkis maziau nei 5");
            }



        }
    }
}
