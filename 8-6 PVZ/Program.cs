using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsitiktinis = new Random();        // random skaiciukas sita reik viena kart pries cikla nes ima laiko momenta skaiciui paimti
            var Pirmas = atsitiktinis.Next(1, 21); // random skaiciuka sugeneruoja  nuo 1 iki 20 (pirma skaiciu iskaito)

            Console.WriteLine("Bandykite atspeti slapta skaiciuka nuo 1 iki 20.");
            var Spejimas = Convert.ToInt32(Console.ReadLine());

            while (Spejimas != Pirmas)
            {
                if (Spejimas > Pirmas)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis");
                }
                else if (Spejimas < Pirmas)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis");
                }

                Console.WriteLine("Bandykite atspeti slapta skaiciuka nuo 1 iki 20.");
                Spejimas = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("ATSPEJOTE!!!!!1!!1!!!!!!1!!!!!!11!!1!!!!");

            

        }
    }
}
