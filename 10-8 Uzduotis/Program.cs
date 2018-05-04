using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_8_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ryja = 8.3;
            var Keliones = new int[] { 70, 200, 47, 58, 356, 154, 24 };
            var Trumpiausia = Keliones[0];
            var Ilgiausia = Keliones[0];
            var Suma = 0;

            for (int i = 0; i < Keliones.Length; i++)
            {
                if (Keliones[i] < Trumpiausia)
                {
                    Trumpiausia = Keliones[i];
                }
                if (Keliones[i] > Ilgiausia)
                {
                    Ilgiausia = Keliones[i];
                }
                Suma += Keliones[i];
            }
            var Sunaudojo = (double)Suma / 100 * Ryja;
            Console.WriteLine("Ilgiausia kelione: " + Ilgiausia);
            Console.WriteLine("Trumpiausia kelione: " + Trumpiausia);
            Console.WriteLine("Kiek kuro sunaudojo: " + Math.Round(Sunaudojo, 2));

        }
    }
}
