using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Temperaturos = new int[] { 15, 10, 7, 15, 16, 30, 52, 11 };

            var min = Temperaturos[0];
            var max = Temperaturos[0];
            
            
            var suma = 0;
            var Maziau = 0;
            var Daugiau = 0;

            foreach (var Temperatura in Temperaturos)
            {
                suma += Temperatura;
                if (Temperatura < min)
                {
                    min = Temperatura;
                }
                if (Temperatura > max)
                {
                    max = Temperatura;
                }
            }

            var vidurkis = (double)suma / Temperaturos.Length;

            for (int i = 0; i < Temperaturos.Length; i++)
            {
                if (Temperaturos[i]<vidurkis)
                {
                    Maziau++;
                }
                if (Temperaturos[i] > vidurkis)
                {
                    Daugiau++;
                }
            }
            Console.WriteLine("Maziausia temperatura "+min);

            Console.WriteLine("Didziausia temperatura "+max);

            Console.WriteLine("Temperaturos vidurkis "+vidurkis);
           
            Console.WriteLine("Temperaturu kiekis maziau uz vidurki " + Maziau);

            Console.WriteLine("Temperaturu kiekis daugiau uz vidurki " + Daugiau);

        }
    }
}
