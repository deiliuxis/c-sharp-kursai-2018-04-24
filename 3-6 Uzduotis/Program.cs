using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Skaicius = 24;
            var PirmasSkaicius = Skaicius / 6;
            var AntrasSkaicius = Skaicius / 12;
            Console.WriteLine("Skaiciaus 24 skaitmenu sandauga yra lygi {0}",PirmasSkaicius*AntrasSkaicius);
        }
    }
}
