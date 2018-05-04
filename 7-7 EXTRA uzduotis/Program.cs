using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_EXTRA_uzduotis
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Iveskite pirmaji skaiciu");
            var Skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu");
            var Skaicius2 = Convert.ToInt32(Console.ReadLine());
            var Atsakymas = 0;
           

            for (int i = 0; i < Skaicius2; i++)
            {
                Atsakymas += Skaicius;
            }
            Console.WriteLine(Atsakymas);

            
        }
    }
}
