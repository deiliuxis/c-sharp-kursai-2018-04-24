using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite koki nors skaiciuka: ");
            var Skaiciukas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Skaiciukas*Skaiciukas);
        }
    }
}
