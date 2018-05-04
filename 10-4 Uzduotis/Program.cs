using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaiciai = new int[] { 1, 5, 4, 7, 9, 6, 5, 3, 1 };

            var Suma = 0;
            var suma = 0;
            var Sumele = 0;
            //------------------------------------------------
            foreach (var Skaicius in Skaiciai)
            {
                Suma += Skaicius;                           // Pirmas budas

            }
            Console.WriteLine(Suma);
            //-------------------------------------------------
            for (int i = 0; i < Skaiciai.Length; i++)
            {
                suma += Skaiciai[i];                        // Antras budas
                Sumele = Skaiciai.Sum();// extra
            }
            Console.WriteLine(suma);
            Console.WriteLine(Sumele);//extra
            //--------------------------------------------------

        }
    }
}
