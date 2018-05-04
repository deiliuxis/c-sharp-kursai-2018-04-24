using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Iveskite temperatura C laipsniais:");
              var Laipsniai = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("{0} laipsniai yra lygu {1} kelvinais ir {2} fahrenheitais.",Laipsniai,Laipsniai+273.15,Laipsniai * ((double)9 / 5) + 32);// jei nera double neskaiciuoja nes viska pmeta po kablelio

      */
            var skaicius = 2;

            while (true)
            {
                if (skaicius > 5)
                {
                    break;
                }
                Console.WriteLine(skaicius + " ");
                skaicius++;
            }

        }
    }
}
