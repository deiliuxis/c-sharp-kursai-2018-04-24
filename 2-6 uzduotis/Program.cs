using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Marke = "Volvo";
            var Modelis = "S60";
            var Metai = 2016;
            var Rida = 25354;

            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3}km.", Marke, Modelis, Metai, Rida);
        }
    }
}
