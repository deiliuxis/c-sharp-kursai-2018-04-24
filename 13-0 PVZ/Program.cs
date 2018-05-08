using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_0_PVZ
{
    class Automobilis
    {
        // public A - pascal case
        // private _abvAbc - camel case
        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string ValstybinisNumeris;
        public Automobilis()
        {

        }

        public Automobilis(int gimimoMetai = 0, string spalva = "-", string marke = "-", string vin = "-", string valstybinisNumeris = "-")
        {
            GimimoMetai = gimimoMetai;
            Spalva = spalva;
            Marke = marke;
            VIN = vin;
            ValstybinisNumeris = valstybinisNumeris;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0}, pagamintas {1}, vin kodas {2}, valstybinis numeris {3}, spalva {4}",Marke,GimimoMetai,VIN,ValstybinisNumeris,Spalva);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis(); // objektas
            auto.GimimoMetai = 2005;
            auto.Spalva = "Melyna";

            var auto2 = new Automobilis()
            {
                GimimoMetai = 205,
                Spalva = "Juoda",
                Marke = "aaa"
            };
            Console.WriteLine(auto2.Marke);
            Console.WriteLine(auto2.Spalva);
            Console.WriteLine(auto2.GimimoMetai);

            var auto3 = new Automobilis(2008,"zalia","audi","gfd5hdf4h65fg6j","abc458");
            var auto4 = new Automobilis(gimimoMetai: 2008,  marke: "audi");
            auto3.Isvedimas();
            auto4.Isvedimas();



            // var auto4 = new Automobilis(spalva: "agfgfg");
        }
    }
}
