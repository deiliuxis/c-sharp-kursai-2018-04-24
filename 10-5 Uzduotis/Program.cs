using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new int[] { 2, 4, 5, 4, 7, 8, 5, 1, 2, 2, 4, 5, 9, 57 };

            var max = Skaiciai[0];
            var min = Skaiciai[0];

            foreach (var Skaicius in Skaiciai)
            {
                if (Skaicius > max)
                {
                    max = Skaicius;
                }
            }
            //-----------------------------------------
            for (int i = 0; i < Skaiciai.Length; i++)
            {
                if (Skaiciai[i] < min)
                { 
                    min = Skaiciai[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);

        }
    }
}
