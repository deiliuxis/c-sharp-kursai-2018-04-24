using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 100; i++)
            {
                
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzFuzzzzzzzzzzzzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
