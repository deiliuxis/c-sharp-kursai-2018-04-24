using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Skaiciai = { 1, 2, 5, 4, 7, 1, 2, 4, 7, 8, 9, 6, 5 };

            foreach (var Skaicius in Skaiciai)
            {
                if (Skaicius% 2 == 0)
                {
                    Console.WriteLine(Skaicius + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
