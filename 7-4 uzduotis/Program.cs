using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int skaicius = 1; skaicius <= 10; skaicius++)
            {
                if (skaicius % 2 == 0 )
                {
                    Console.WriteLine(skaicius);
                }
            }
        }
    }
}
