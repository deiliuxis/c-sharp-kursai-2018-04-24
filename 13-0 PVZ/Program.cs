using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_0_PVZ
{
    class Automobilis
    {
        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string ValstybinisNumeris;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis(); // objektas
            auto.GimimoMetai = 2005;
            auto.Spalva = "Melyna";
        }
    }
}
