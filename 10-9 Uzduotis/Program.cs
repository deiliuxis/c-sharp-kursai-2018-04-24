using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
            var Skaicius3 = new int[10];
            Skaicius3[0] = 1;
            Skaicius3[1] = 1;
            

            for (int i = 2; i < Skaicius3.Length; i++)
            {
                Skaicius3[i] = Skaicius3[i-1] + Skaicius3[i-2];
              

                
            }
            foreach (var Skaicius in Skaicius3)
            {
                Console.Write(Skaicius + " ");
            }
        }
    }
}
