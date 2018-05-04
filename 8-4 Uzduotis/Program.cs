using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Uzrasas = "Iveskite zodi arba exit: ";
            Console.Write(Uzrasas + "");
            string Zodis = Console.ReadLine();
            string Zodelis = Zodis + " ";
            
            
            

            while (Zodis != "exit")
            {
                
                Console.Write(Uzrasas + "");
                Zodis = Console.ReadLine();

                if (Zodis != "exit")
                {


                    Zodelis += Zodis + " ";
                }
                
            }
            Console.WriteLine(Zodelis);
           
            

        }
    }
}
