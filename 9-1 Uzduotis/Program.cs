using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Skaicius = 0;
            int Skaicius2 = 0;
            var Atsakymas = 0;
            for (int i = 0; i <= 100; i++)
            {
                Skaicius += i;
            }
            for (int i = 0; i <= 100; i++)
            {
                Skaicius2 += i * i;
            }

            Atsakymas = Skaicius * Skaicius - Skaicius2;
            Console.WriteLine(Atsakymas);
        }
    }
}
