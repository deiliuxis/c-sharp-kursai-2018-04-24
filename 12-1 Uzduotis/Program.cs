using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Programa = new Program();
            var vartotojoVardas = Programa.VartotojaVardas();
            var vartotojoAmzius = Programa.VartotojoAmzius();

            var Skaicius = Programa.Listai();
            Programa.Spausdinimas(Skaicius);

            Programa.DuSkaiciai();
            Programa.Pasisveinimas(vartotojoVardas, vartotojoAmzius);

        }

        public void Pasisveinimas(string Vardas, int Amzius)
        {
            Console.WriteLine("Sveiki, " + Vardas + " jusu amzius yra " + Amzius);
        }
        public string VartotojaVardas()
        {
            Console.WriteLine("Iveskite savo varda");
            var Vardas = Console.ReadLine();


            return Vardas;

        }

        public int VartotojoAmzius()
        {
            Console.WriteLine("Iveskite savo amziu: ");
            var Amzius = Convert.ToInt32(Console.ReadLine());

            return Amzius;


        }

        public int Suma(int Skaicius1, int Skaicius2)
        {
            return Skaicius1 + Skaicius2;
        }

        public void DuSkaiciai()
        {
            Console.WriteLine("Iveskite pirmaji skaiciu: ");
            var Skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu: ");
            var Skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Suma(Skaicius1, Skaicius2));


        }

        public List<int> Listai()
        {
            List<int> Skaiciukai = new List<int>();
            Console.WriteLine("Kiek skaiciuku noresite");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Kiek; i++)
            {

                Console.WriteLine("Iveskite {0} skaiciuka", i + 1);
                var Skaicius = Convert.ToInt32(Console.ReadLine());
                Skaiciukai.Add(Skaicius);

            }
            return Skaiciukai;
        }




        public void Spausdinimas(List<int> Skaicius)
        {
            foreach (var Skakciukas in Skaicius)
            {
                Console.Write(Skakciukas + " ");
            }
            Console.WriteLine();

            Console.WriteLine(Didziausias(Skaicius));
            Console.WriteLine(Vidurkis(Skaicius));
        }

       
        public int Didziausias(List<int> Skaicius)
        {
            var Didziausias = 0;
            foreach (var Skaiciuks in Skaicius)
            {
                if (Didziausias < Skaiciuks)
                {
                    Didziausias = Skaiciuks;
                }
            }

            return Didziausias;
        }

        public int Sumele(List<int> Skaicius)
        {
            var suma = 0;
            foreach (var skaiciuks in Skaicius)
            {
                suma += skaiciuks;
            }
            return suma;
        }

       public int Vidurkis(List<int> Skaicius)
        {
            var suma = Sumele(Skaicius);
            var vidurkis = suma / Skaicius.Count;

            return vidurkis;

        }
    }
}
