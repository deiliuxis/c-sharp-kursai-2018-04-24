using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite bet koki sveikaji skaiciu:");
            var skaiciuks = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", skaiciuks, i, skaiciuks*i);
            }
            
        }
    }
}
