using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek darbuotas gali iskepti kepalu per valanda");
            var Valanda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek darbuotoju turi kepykla");
            var Darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina");
            var Savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina");
            var Kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kiek kepykla turi ta diena uzsakymu");
            var Uzsakymai = Convert.ToInt32(Console.ReadLine());

            var DarboValandos = 8;

            var KiekIskeps = Darbuotojai * Valanda * DarboValandos;
            Console.WriteLine("Per viena darbo diena kepykla iskeps {0} duonos kepalu.", KiekIskeps);

            if (KiekIskeps >= Uzsakymai)
            {
                var Savikaina2 = Uzsakymai * Savikaina;
                var Pajamos = Kaina * Uzsakymai;
                var Pelnas = Pajamos - Savikaina2;
                Console.WriteLine("Visu kepalu savikaina: {0} eur. , Visu pardavimu suma: {1} eur. , Gautas pelnas: {2} eur.", Savikaina2, Pajamos, Pelnas);
            }

            
            else
            {
                var Savikaina2 = KiekIskeps * Savikaina;
                var Pajamos = Kaina * KiekIskeps;
                var Pelnas = Pajamos - Savikaina2;
                Console.WriteLine("Visu kepalu savikaina: {0} eur. , Visu pardavimu suma: {1} eur. , Gautas pelnas: {2} eur.", Savikaina2, Pajamos, Pelnas);
            }



            if (Uzsakymai <= KiekIskeps)
            {
                Console.WriteLine("Kepykla spes iskepti visus uzsakymus");
            }
            else
            {
                var Nespes = Uzsakymai - KiekIskeps;
                Console.WriteLine("Kepykla nespes iskepti {0} uzsakymu.", Nespes);
            }



        }
    }
}
