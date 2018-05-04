using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 0;

            for (int i = 20; i < 50; i++)
            {
                if (i % 2 == 0)
                {

                    Skaicius += i;
                }
            }

            Console.WriteLine(Skaicius-20);
        }
    }
}
