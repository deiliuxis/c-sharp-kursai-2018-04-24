using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaiciu");
            var Skaicius = Convert.ToDouble(Console.ReadLine());

            if (Skaicius < 0)
            {
                Console.WriteLine("SAKIAU IVEST TEIGIAMA LOHAS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

            if (Skaicius>0)
            {
                Console.WriteLine("Labai gerai :)))");
            }

            if (Skaicius % 2 == 0)
            {
                Console.WriteLine("Jusu skaicius lyginis");
            }

            if (Skaicius % 4 == 0)
            {
                Console.WriteLine("Jusu skaicius dalinasi is 4");

            }

            if (Skaicius > 10)
            {
                Console.WriteLine("Jusu skaicius didesnis uz 10");
            }
        }
    }
}
