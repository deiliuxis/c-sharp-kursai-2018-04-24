using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_12_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kiek norite skaiciu: ");
            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());

            var Pirmas = 1;
            var Antras = 1;
            var Trecias = 0;

            while (Pasirinkimas < 1)
            {
                Console.Write("Iveskite skaiciu is naujo: ");
                Pasirinkimas = Convert.ToInt32(Console.ReadLine());
            }

            if (Pasirinkimas > 2)
            {



                Console.Write(Pirmas + " " + Antras + " ");


                for (int i = 2; i < Pasirinkimas; i++)
                {

                    Trecias = Pirmas + Antras;
                    Pirmas = Antras;
                    Antras = Trecias;
                    Console.Write(Trecias + " ");
                  

                }


            }
            else if (Pasirinkimas == 2)
            {
                Console.WriteLine(Pirmas + " " + Antras);
            }
            else if (Pasirinkimas == 1)
            {
                Console.WriteLine(Pirmas);
            }
            
        }
    }
}
