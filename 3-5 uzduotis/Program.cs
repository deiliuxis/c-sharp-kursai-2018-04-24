using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 8;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",skaicius,i,skaicius*i);
            }
            
        }
    }
}
