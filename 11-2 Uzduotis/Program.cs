using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek studentu pazymiu norite ivesti i sarasa?");
            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());

            List<int> Pazymiai = new List<int>();

            int suma = 0;

            for (int i = 0; i < Pasirinkimas; i++)
            {
                Console.WriteLine("Iveskite {0} pazimi: ",i+1);
                var Pazimys = Convert.ToInt32(Console.ReadLine());
                Pazymiai.Add(Pazimys);
                suma += Pazymiai[i];
            }

            var vidurkis = (double)suma / Pazymiai.Count;
            int min = Pazymiai[0];
            int max = Pazymiai[0];
           
            foreach (var Pazimys in Pazymiai)
            {
                if (Pazimys < min)
                {
                    min = Pazimys;
                }
                if (Pazimys > max)
                {
                    max = Pazimys;
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(vidurkis);

            var SkaiciaiRandom = new Random();

            Console.WriteLine(Pazymiai[SkaiciaiRandom.Next(0,Pazymiai.Count)]); // randa random sarase !!!!!1!!!111!!!!11!
        }
    }
}
