using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_0_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            skaiciai.Add(7);
            skaiciai.Add(2);

            List<string> zodziai = new List<string> { "Medis", "Labas", "Masina" };

            //Vietoj lenght cia naudot count

            Console.WriteLine(skaiciai.Sum());
            Console.WriteLine(skaiciai.Average());
            Console.WriteLine(skaiciai.Count());
            Console.WriteLine(skaiciai.Min());
            Console.WriteLine(skaiciai.Max());



        }
    }
}
