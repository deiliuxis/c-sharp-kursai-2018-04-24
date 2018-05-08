using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_Uzduotis
{
    class ParduotuvesDuomenys
    {
        public string Pavadinimas;
        public string Adresas;
        public int Plotas;
        public List<PrekesDuomenys> Prekes;

        public ParduotuvesDuomenys()
        {
            Prekes = new List<PrekesDuomenys>();
        }

        public ParduotuvesDuomenys(string pavadinimas,string adresas, int plotas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Plotas = plotas;
            Prekes = new List<PrekesDuomenys>();
        }

        public ParduotuvesDuomenys(string pavadinimas, string adresas, int plotas, List<PrekesDuomenys> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Plotas = plotas;
            Prekes = prekes;
        }

        public void Ivedimas()
        {
            Console.Write("Kiek duomenu noresite");
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i + 1 + " prekes duomenys:");
                Prekes.Add(new PrekesDuomenys());
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Parduotuve {0} kurios adresas {1}", Pavadinimas,Adresas);
            Console.WriteLine();
            
            foreach (var Preke in Prekes)
            {
                Preke.Isvedimas();
                
            }
            Console.WriteLine();
            Console.Write("Mazo likucio prekes: ");
            foreach (var Preke in Prekes)
            {
                if (Preke.Likutis() == true)
                {
                    Console.Write(Preke.Pavadinimas + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Daugiausiai kiekio turincios prekes duomenys:");
            Console.WriteLine();
            Prekes.ElementAt(Daugiausiai()).Isvedimas();
            Console.WriteLine();
            Console.WriteLine("Didziausia kaina turincios prekes info: ");
            Console.WriteLine();
            Didziausia().Isvedimas();
            Console.WriteLine();
            Console.WriteLine("Didziausia pelna turincios prekes info: ");
            Console.WriteLine();
            DidziausiasPelnas().Isvedimas();
            Console.WriteLine();
            Console.Write("Visas parduotuves pelnas: "+ VisasPelnas());
            Console.WriteLine();
            
            
        }

        public int Daugiausiai()
        {
            var daugiausiai = 0;
            var indeksas = 0;
            for (int i = 0; i < Prekes.Count; i++)
            {
                
                    if (Prekes[i].Kiekis > daugiausiai)
                    {
                        daugiausiai = Prekes[i].Kiekis;
                        indeksas = i;
                    }
                
            }
            return indeksas;

        }

        public PrekesDuomenys Didziausia()
        {
            var didziausia = Prekes.First();
            foreach (var Preke in Prekes)
            {
                if (didziausia.Kaina < Preke.Kaina)
                {
                    didziausia.Kaina = Preke.Kaina;
                }
            }

            return didziausia;
        }

        public PrekesDuomenys DidziausiasPelnas()
        {
            var didziausias = Prekes.First();
            foreach (var Preke in Prekes)
            {
                if (didziausias.Pelnas() < Preke.Pelnas())
                {
                    didziausias = Preke;
                }
            }
            return didziausias;
        }

        public double VisasPelnas()
        {
            double Visas = 0;
            foreach (var Preke in Prekes)
            {
                Visas += Preke.Pelnas() * Preke.Kiekis;
            }

            return Visas;
        }
    }
}
