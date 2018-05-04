using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = 8;
            var kvadratas = Math.Pow(a,2); // pakelia kvadratu
            var kubas = Math.Pow(a,3); // pakelia kubu
            Console.WriteLine("Skaicius: {0} Kvadratu: {1} Kubu: {2} ", a, kvadratas, kubas);
        }
    }
}
