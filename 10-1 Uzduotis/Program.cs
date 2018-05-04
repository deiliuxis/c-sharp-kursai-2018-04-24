using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Pazymiai = new int[5];
            string[] Marke = new string[5];
            char[] Raidele = new char[5];

           // Console.WriteLine("Iveskite 3 skaicius:");

           


            

            Marke[0] = "Audi";
            Marke[1] = "Bmw";
            Marke[2] = "WW";
            Marke[3] = "CT";
            Marke[4] = "Volvo";

            Raidele[0] = 'a';
            Raidele[1] = 'y';
            Raidele[2] = 't';
            Raidele[3] = 'b';
            Raidele[4] = 'g';

            int[] Pazymiai1 = { 4, 5, 8, 7, 5, 6, 6, 4, 1, 2, 5 };
            Console.WriteLine(Pazymiai1[4]);
            string[] Marke1 =
            {
                "Audi","Bmw","Volvo","WW"
            };
            Console.WriteLine(Marke1[3]);

            char[] Raideles1 = { 'a', 'g', 'b' };
            Console.WriteLine(Raideles1[1]);

            Console.WriteLine(Raidele.Length);
            Console.WriteLine(Raidele.First());
            Console.WriteLine(Raidele[Raidele.Length-1]);

            //MasyvoPavadinimas.Lenght
            //MasyvoPavadinimas.First() -
            //MasyvoPavadinimas.Last()  -
            //MasyvoPavadinimas[MasyvoPavadinimas.Lenght-1]  - Paima paskutine reiksme masyve

            //int[] skaiciai = { 1, 2, 4, 5, 8, 9 };
            // Console.WriteLine(skaiciai.Length);
            //Console.WriteLine(skaiciai.First());
            // Console.WriteLine(skaiciai[skaiciai.Length-2]);

            int[] Skaiciai = { 0, 1, 2, 5, 4, 5 };
            foreach (var Skaicius in Skaiciai)
            {
                Console.Write(Skaicius + " ");
            }




        }
    }
}
