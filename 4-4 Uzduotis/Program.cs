using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            var trecias = Convert.ToInt32(Console.ReadLine());

          

            Console.WriteLine("{0} + {1} + {2}  = {3}", pirmas, antras, trecias, pirmas + antras + trecias);
            Console.WriteLine("{0} - {1} - {2}  = {3}", pirmas, antras, trecias, pirmas - antras - trecias);
            Console.WriteLine("{0} * {1} * {2}  = {3}", pirmas, antras, trecias, pirmas * antras * trecias);
            Console.WriteLine("{0} / {1} / {2}  = {3}", pirmas, antras, trecias, Math.Round((double)pirmas / antras / trecias, 5));
        }
    }
}
