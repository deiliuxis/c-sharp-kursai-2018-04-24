using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Zodziai = new List<string>
            {
                "Medis","Lapas","Masina","Nuoma","Modeliukas"

            };

            int Min = Zodziai.First().Length; // su trumpiausiu sunkiau nes jei prisilyginsi tusciai eilutei arba 0 nemes ats
            var Trumpiausias = Zodziai.First(); // svarbu
            int Max = 0;
            var Ilgiausias = "";
            for (int i = 0; i < Zodziai.Count; i++)
            {
                if (Zodziai[i].Length > Max)
                {
                    Max = Zodziai[i].Length;
                    Ilgiausias = Zodziai[i];
                }

                if (Zodziai[i].Length < Min)
                {
                    Min = Zodziai[i].Length;
                    Trumpiausias = Zodziai[i];
                }
            }
            Console.WriteLine(Ilgiausias + " " + Ilgiausias.Length);
            Console.WriteLine(Trumpiausias + " " + Trumpiausias.Length);

        }
    }
}
