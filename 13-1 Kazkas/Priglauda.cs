using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Kazkas
{
    class Priglauda
    {
        public string Pavadinimas;
        public string Adresas;
        //public List<Suo> Sunys = new List<Suo>();
        public List<Suo> Sunys;


        public Priglauda(string pavadinimas,string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = new List<Suo>();
        }

        public Priglauda(string pavadinimas, string adresas, List<Suo> sunys)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = sunys;
        }

        public void Checkin()
        {
            Console.Write("Kiek sunu prisichekins");
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i+1 + " suns duomenys:" );
                Sunys.Add(new Suo());
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Prieglaudos pavadinimas {0} kurios adresas {1}",Pavadinimas,Adresas);
            Console.WriteLine();
            foreach (var suo in Sunys)
            {
                suo.Isvedimas();
            }
            Console.WriteLine("Vyriausio suns info: ");
            VyriausiasSuo().Isvedimas();
            Console.WriteLine(AmziuVidurkis()); 
        }

        public Suo VyriausiasSuo()
        { 
            var Vyriausias = Sunys.First();
            foreach (var suo in Sunys)
            {
                if (suo.Amzius > Vyriausias.Amzius)
                {
                    Vyriausias = suo;
                }
            }
            return Vyriausias;
        
        }

        public double AmziuVidurkis()
        {
            var Suma = 0;
            

            foreach (var suo in Sunys)
            {
                Suma += suo.Amzius;
            }

            var vidurkis = (double)Suma / Sunys.Count;

            return vidurkis;

        }

       /* public Suo DazniausiosVeisles()
        {
            Dictionary<string, int> Veisles = new Dictionary<string, int>();

            foreach (var suo in Sunys)
            {
                if (Veisles.ContainsKey("Terjeras"))
                {

                }
            }

        }
        */
    }
}
