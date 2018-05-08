using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Kazkas
{
    class Suo
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;

        public Suo(string vardas,string veisle = "-",int amzius = 0)
        {
            Vardas = vardas;
            Veisle = veisle;
            Amzius = amzius;
        }

        public Suo()
        {
            Console.Write("Iveskite amziu:");
            Amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite veiste:");
            Veisle = Console.ReadLine();
            Console.Write("Iveskite varda");
            Vardas = Console.ReadLine();
        }

        public void Isvedimas()
        {
            Console.WriteLine("Suo vardu {0} veisle {1} amzius {2}",Vardas,Veisle,Amzius);

        }
    }
}
