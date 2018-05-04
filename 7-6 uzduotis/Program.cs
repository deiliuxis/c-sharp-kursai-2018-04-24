using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia :");

            var Pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite reziu  pabaiga:");

            var Pabaiga = Convert.ToInt32(Console.ReadLine());

            if (Pradzia<Pabaiga)
            {
                for (int i = Pradzia; i < Pabaiga; i++)
                {
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
