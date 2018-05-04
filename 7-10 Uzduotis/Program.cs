using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 ==0)
                {
                    Skaicius += i;
                }
            }
            Console.WriteLine(Skaicius);
        }
    }
}
