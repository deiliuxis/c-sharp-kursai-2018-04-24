using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_0_Pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program(); // sukuriama objekta ir ant jo dedame metodus
            programa.Pasisveikinti();
            programa.Pasisveikinti();
            programa.Pasisveikinti();
            programa.Pasisveikinti();
            programa.Pasisveikinti();
            programa.Pasisveikinti();
            Atsisveikinti();

            Program.Atsisveikinti(); // nes toje pacioje klaseje Program klase yra :P

            
        }

        // cia kiti metodai

        public void Pasisveikinti()
        {
            Console.WriteLine("HELLLOOOO");
        }

        public static void Atsisveikinti()
        {
            Console.WriteLine("Ate :'(");
        }
    }
}
