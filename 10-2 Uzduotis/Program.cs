using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kiek duomenu noretumete?");
            var Kiek = Convert.ToInt32(Console.ReadLine());

            string[] Zodziai = new string[Kiek];
            

            


            for (int i = 0; i < Zodziai.Length; i++)
            {
                Console.WriteLine("Iveskite zodeli:");
                Zodziai[i] = Console.ReadLine();
                
            } 

           
            foreach (var Zodis in Zodziai)
            {
                Console.Write(Zodis + " ");
            }
            Console.WriteLine();
        }
    }
}
