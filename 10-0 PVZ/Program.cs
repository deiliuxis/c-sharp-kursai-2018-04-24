using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_0_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] labas = { }; // duomenis i vidu
            //int[] Sveikas = new Sveikas[15];

            int[] Skaiciai = { 8, 7, 4, 6, 4, 5, 2, 1 };
            Console.WriteLine(Skaiciai[0]); // irasys 8
            Console.WriteLine(Skaiciai[3]); // irasys 6

            int[] Skaiciukai = new int[5];
            Skaiciukai[0] = 9;
            Skaiciukai[1] = 8; // surasin info iki [4]
            string[] Tekstas = new string[3];

            Tekstas[0] = "Sveiki draugai";
            Tekstas[1] = "Sveiki draugassssgi";
        }
    }
}
