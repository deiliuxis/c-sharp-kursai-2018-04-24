using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_Sugalvotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();

            Console.WriteLine("Mokykla 2016");
            Console.WriteLine();
            var Pazymiai2016 = programa.Ivedimas();
            Console.WriteLine();

            Console.WriteLine("Mokykla 2017");
            Console.WriteLine();
            var Pazymiai2017 = programa.Ivedimas();
            Console.WriteLine();

            programa.Isvedimas(Pazymiai2016, Pazymiai2017);


        }

        public Dictionary<string, int> Ivedimas()
        {
            var Mokiniai = new Dictionary<string, int>();
            Console.Write("Kiek duomenu noresite: ");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Kiek; i++)
            {
                Console.Write("Koks mokinio vardas: ");
                var Vardas = Console.ReadLine();
                Console.Write("Koks mokinio pazymiu vidurkis: ");
                var Pazimys = Convert.ToInt32(Console.ReadLine());

                Mokiniai.Add(Vardas, Pazimys);
            }
            return Mokiniai;

        }
        public void Isvedimas(Dictionary<string, int> Mokiniai, Dictionary<string, int> Mokiniai2)
        {
            Console.WriteLine("2016 metai: ");
            Console.WriteLine();

            Console.WriteLine("Mokiniu vidurkis: " + Math.Round(Vidurkis(Mokiniai)), 3);
            Console.WriteLine("Didziausias mokinio vidurkis: " + Mokiniai.ElementAt(Didziausias(Mokiniai)).Key + " " + Mokiniai.ElementAt(Didziausias(Mokiniai)).Value);
            Console.WriteLine();

            Console.WriteLine("2017 metai: ");
            Console.WriteLine();

            Console.WriteLine("Mokiniu vidurkis: " + Math.Round(Vidurkis(Mokiniai2)), 3);
            Console.WriteLine("Didziausias mokinio vidurkis: " + Mokiniai2.ElementAt(Didziausias(Mokiniai2)).Key + " " + Mokiniai2.ElementAt(Didziausias(Mokiniai2)).Value);
            Console.WriteLine();

            Palyginimas(Mokiniai, Mokiniai2);
            Laimetojas(Mokiniai, Mokiniai2);


        }
        public double Vidurkis(Dictionary<string, int> Mokiniai)
        {

            var suma = 0;
            foreach (var Pazimys in Mokiniai)
            {
                suma += Pazimys.Value;
            }

            return (double)suma / Mokiniai.Count;
        }

        public int Didziausias(Dictionary<string, int> Mokiniai)
        {
            var didziausias = Mokiniai.ElementAt(0).Value;
            var indeksas = 0;
            for (int i = 0; i < Mokiniai.Count; i++)
            {
                if (didziausias < Mokiniai.ElementAt(i).Value)
                {
                    indeksas = i;
                    didziausias = Mokiniai.ElementAt(i).Value;
                }
            }
            return indeksas;
        }

        public void Palyginimas(Dictionary<string, int> Metai2016, Dictionary<string, int> Metai2017)
        {
            if (Vidurkis(Metai2016) > Vidurkis(Metai2017))
            {
                Console.WriteLine("2016 metu vidurkis buvo didesnis");
            }
            else if (Vidurkis(Metai2017) > Vidurkis(Metai2016))
            {
                Console.WriteLine("2017 metu vidurkis buvo didesnis");
            }
            else
            {
                Console.WriteLine("Vidurkiai vienodi");
            }


        }

        public void Laimetojas(Dictionary<string, int> Metai2016, Dictionary<string, int> Metai2017)
        {
            if (Metai2016.ElementAt(Didziausias(Metai2016)).Value > Metai2017.ElementAt(Didziausias(Metai2017)).Value)
            {
                Console.WriteLine("Geriausias mokyklos mokinys: " + Metai2016.ElementAt(Didziausias(Metai2016)));
            }
            else if (Metai2016.ElementAt(Didziausias(Metai2016)).Value < Metai2017.ElementAt(Didziausias(Metai2017)).Value)
            {
                Console.WriteLine("Geriausias mokyklos mokinys: " + Metai2017.ElementAt(Didziausias(Metai2017)));
            }
            else
            {
                Console.WriteLine("meh");
            }

        }

        // pasidaryt out ir ref pavizdys skaidrese !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    }
}
