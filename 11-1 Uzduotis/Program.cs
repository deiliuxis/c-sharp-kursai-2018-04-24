using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var SkaiciaiRandom = new Random();
            
            var Dydis = SkaiciaiRandom.Next(1, 101);

            List<int> Skaiciukai = new List<int>();



            int suma = 0;
            for (int i = 0; i < Dydis; i++)
            {
                var Skaiciai = SkaiciaiRandom.Next(1, 101);
                Skaiciukai.Add(Skaiciai);
                suma += Skaiciukai[i];
            }

            int min = Skaiciukai[0];
            int max = Skaiciukai[0];
            var vidurkis = suma / Skaiciukai.Count;
            int maziau = 0;
            int sumele = 0;


            foreach (var Skaicius in Skaiciukai)
            {
                if (Skaicius > max)
                {
                    max = Skaicius;
                }
                if (Skaicius < min)
                {
                    min = Skaicius;
                }
                if (Skaicius < vidurkis)
                {
                    maziau++;
                }
                if (Skaicius % 2 == 0)
                {
                    sumele += Skaicius;
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(vidurkis);
            Console.WriteLine(maziau);
            Console.WriteLine(sumele);


        }
    }
}
