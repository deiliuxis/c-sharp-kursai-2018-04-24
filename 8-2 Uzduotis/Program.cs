using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigiama skaiciu:");
            var Skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dekui");

            while (Skaicius <= 0)
            {
                Console.Write(Skaicius + " ");
                Skaicius++;
            }
        }
    }
}
