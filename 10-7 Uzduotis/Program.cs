using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pazymiai = new int[] { 1, 2, 4, 7, 8, 5, 6, 9, 7, 5, 4, 1, 2, 10, 5, 4, 7, 10, 2, 4, 5 };

            var Geriausias = Pazymiai[0];
            var Desimtukininkai = 0;
            var Neigiatukininkai = 0;

            var Suma = 0;

            foreach (var Pazimys in Pazymiai)
            {
                if (Pazimys > Geriausias)
                {
                    Geriausias = Pazimys;
                }
                if (Pazimys == 10)
                {
                    Desimtukininkai++;
                }
                if (Pazimys < 4)
                {
                    Neigiatukininkai++;
                }
                Suma += Pazimys;

            }
            var Vidurkis = (double)Suma / Pazymiai.Length;

            Console.WriteLine("Geriausias pazimys: " + Geriausias);
            Console.WriteLine("Studentu skaicius kurie gavo 10: " + Desimtukininkai);
            Console.WriteLine("Studentu skaicius kurie gavo neigiama: " + Neigiatukininkai);
            Console.WriteLine("Visu pazymiu vidurkis: " + Math.Round(Vidurkis, 2));
        }
    }
}
