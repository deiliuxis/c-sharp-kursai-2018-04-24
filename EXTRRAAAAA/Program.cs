using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRRAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {

            // 52 Uzduotis butu cool padaryt
            Console.WriteLine("Iveskite skaiciu");
            var Skaicius = Convert.ToDouble(Console.ReadLine());

            var Galutinis = 1 / Skaicius;
            var galutinis = 0;

            Console.WriteLine("{0} = 1/{1}",Skaicius,Galutinis);
            
            if (Galutinis % 2 != 0 || Galutinis % 3 != 0|| Galutinis % 5 != 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    galutinis = Galutinis * i;
                }
            }
            
            
            
        
        }
    }
}
