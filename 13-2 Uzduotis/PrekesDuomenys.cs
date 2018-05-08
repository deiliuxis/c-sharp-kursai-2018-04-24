using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_Uzduotis
{
    class PrekesDuomenys
    {
        public string Pavadinimas;
        public double Kaina;
        public double Savikaina;
        public int Kiekis;

       

        public PrekesDuomenys(string pavadinimas,double kaina,double savikaina,int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;

        }

        public double Pelnas()
        {
            var Pelnas = Kaina - Savikaina;

            return Pelnas;
        }

        public bool Likutis()
        {
            bool MazasKiekis = false;

            if(Kiekis <5)
            {
                MazasKiekis = true;
            }

            return MazasKiekis;
        }

        public PrekesDuomenys()
        {
            Console.Write("Iveskite prekes pavadinima ");
            Pavadinimas = Console.ReadLine();
            Console.Write("Iveskite prekes kaina ");
            Kaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite savikaina ");
            Savikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite prekes kieki ");
            Kiekis = Convert.ToInt32(Console.ReadLine());
        }

        public void Isvedimas()
        {
            Console.WriteLine("Preke pavadinimu {0} kurios kaina {1} ir savikaina {2} , jos turimas kiekis {3}.",Pavadinimas,Kaina,Savikaina,Kiekis);

        }
    }
}
