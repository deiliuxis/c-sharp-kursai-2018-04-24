using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda: " );
            var Vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu: " );
            var Amzius = Console.ReadLine();

            Console.WriteLine("Jusu vardas {0}, o amzius {1}.", Vardas,Amzius);
        }
    }
}
