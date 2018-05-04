using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia :");

            var Pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite reziu  pabaiga:");

            var Pabaiga = Convert.ToInt32(Console.ReadLine());

            if (Pradzia < Pabaiga)
            {
                for (int i = Pradzia; i < Pabaiga; i++)
                {
                    Console.WriteLine("Skaicius:{0} Kvadratas:{1}", i, i * i);
                }
            }
            else
            {
                Console.WriteLine("Pradzia didesne uz pabaiga xDDDDDDDD");
            }
        }
    }
}
