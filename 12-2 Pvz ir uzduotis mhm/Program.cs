using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_Pvz_ir_uzduotis_mhm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 euroviziju balai
            // sukuri balu sarasa
            // metodai:
            // duomenu suvedimas konsoles pagalba
            // maziausias balas
            // didziausias balas
            // isvedimas
            // kitu metu balu sarasas 
            // kuriame sarase yra didesnis balu vidurkis
            // surasti kuriame sarase yra mazesnis maziausias balas

            Program programa = new Program();

            var Balai2016 = programa.Ivedimas();
            var Balai2017 = programa.Ivedimas();

            Console.WriteLine("2016 metai");
            Console.WriteLine();
            programa.Isvedimas(Balai2016);
            Console.WriteLine();


            Console.WriteLine("2017 metai");
            Console.WriteLine();
            programa.Isvedimas(Balai2017);
            Console.WriteLine();

            programa.Palyginimas(Balai2016, Balai2017);







        }

        public int Suma(Dictionary<string, int> balai)
        {
            var suma = 0;
            foreach (var Balas in balai)
            {
                suma += Balas.Value;
            }
            return suma;
        }

        public Dictionary<string, int> Ivedimas()
        {
            var balai = new Dictionary<string, int>();
            Console.Write("Kiek duomenu norite suvesti? ");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Kiek; i++)
            {
                Console.Write("Iveskite {0} sali: ", i + 1);

                var Salis = Console.ReadLine();

                Console.Write("Iveskite {0} bala: ", i + 1);

                var Balas = Convert.ToInt32(Console.ReadLine());

                balai.Add(Salis, Balas);
            }

            return balai;
        }

        public void Isvedimas(Dictionary<string, int> Mlem)
        {
            foreach (var zodiz in Mlem)
            {
                Console.WriteLine(zodiz.Key + ": " + zodiz.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Balu suma: " + Suma(Mlem));
            Console.WriteLine();
            Console.WriteLine("Balu vidurkis: " + (double)Suma(Mlem) / Mlem.Count);
            Console.WriteLine();


            Console.WriteLine("Maziausiai tasku surinkusi salis: " + Mlem.ElementAt(Maziausias(Mlem)).Key + ": " + Mlem.ElementAt(Maziausias(Mlem)).Value);
            Console.WriteLine("Daugiausiai tasku surinkusi salis: " + Mlem.ElementAt(Didziausias(Mlem)).Key + ": " + Mlem.ElementAt(Didziausias(Mlem)).Value);
            Console.WriteLine("Saliu skaicius turintis daugiau tasku nei vidurkis: " + Daugiau(Mlem));

        }

        public int Maziausias(Dictionary<string, int> Mlem)
        {
            var indeksas = 0;
            var Maziausias = Mlem.ElementAt(0).Value;

            for (int i = 0; i < Mlem.Count; i++)
            {
                if (Mlem.ElementAt(i).Value < Maziausias)
                {
                    indeksas = i;
                    Maziausias = Mlem.ElementAt(i).Value;
                }
            }
            return indeksas;
        }

        public int Didziausias(Dictionary<string, int> Mlem)
        {
            var indeksas = 0;
            var didziausias = Mlem.ElementAt(0).Value;

            for (int i = 0; i < Mlem.Count; i++)
            {
                if (Mlem.ElementAt(i).Value > didziausias)
                {
                    indeksas = i;
                    didziausias = Mlem.ElementAt(i).Value;
                }
            }
            return indeksas;
        }

        public int Daugiau(Dictionary<string, int> Mlem)
        {
            var vidurkis = (double)Suma(Mlem) / Mlem.Count;
            var kiekis = 0;

            foreach (var balas in Mlem)
            {
                if (balas.Value > vidurkis)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }

        public void Palyginimas(Dictionary<string, int> balai1, Dictionary<string, int> balai2)
        {


            var vidurkis1 = (double)Suma(balai1) / balai1.Count;
            var vidurkis2 = (double)Suma(balai2) / balai2.Count;

            if (vidurkis1 > vidurkis2)
            {
                Console.WriteLine("2016 metu didesnis vidurkis");
            }
            else if (vidurkis1 < vidurkis2)
            {
                Console.WriteLine("2017 metu didesnis vidurkis");
            }
            else
            {
                Console.WriteLine("Vidurkis vienodas :OO");
            }



            if (Maziausias(balai1) < Maziausias(balai2))
            {
                Console.WriteLine("2016 metai turejo mazesni maziausia");
            }
            else if (Maziausias(balai1) > Maziausias(balai2))
            {
                Console.WriteLine("2017 metai turejo mazesni maziausia");

            }
            else
            {
                Console.WriteLine("Abieju metu maziausi balai yra lygus");
            }

        }





    }
}
