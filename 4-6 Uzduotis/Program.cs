using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome pirmaji skaiciu: ");
            var Pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prasome antraji skaiciu: ");
            var Antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prasome treciaji skaiciu: ");
            var Trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} skaiciu artitmetinis vidurkis yra {3}",Pirmas,Antras,Trecias,Math.Round((double)(Pirmas+Antras+Trecias)/3,4));
        }
    }
}
