using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_0_bandymai
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Iveskite pin koda: ");
            var PinKodas = Console.ReadLine();

            Console.WriteLine("Iveskite Vardas: ");
            var Vardas = Console.ReadLine();

            Console.WriteLine("Iveskite Pavarde: ");
            var Pavarde = Console.ReadLine();

            Console.WriteLine("Iveskite Metai: ");
            var Metai = Console.ReadLine();

            Console.WriteLine("Iveskite Specialybe: ");
            var Specelybe = Console.ReadLine();

            Console.WriteLine("Iveskite Hobis: ");
            var Hobis = Console.ReadLine();

            Console.WriteLine("Pin Kodas:  "+PinKodas);
            Console.WriteLine("Vardas:     " + Vardas);
            Console.WriteLine("Pavarde:    " + Pavarde);
            Console.WriteLine("Gim Metai:  " + Metai);
            Console.WriteLine("Specialybe: " + Specelybe);
            Console.WriteLine("Mano Hobis: " + Hobis);

            Console.WriteLine("Iveskite Amziu: ");         
            var metukai= Convert.ToInt32(Console.ReadLine()); // kad skaiciu skaitytu kaip skaiciu o  ne stringa

            var skaiciukas = Convert.ToInt32("38"); // tas pats

            var sfhjh = Console.ReadLine(); // tas pats
            var hdfh = Convert.ToInt32(sfhjh);


            short gfdhfdh; // int 16
            int mhgfhnj; // int 36  skiriasi max skaiciai ant ju kai paspaudi go to definition :)
            long gdfhdfh; // int 64

            ushort gfdh;
            uint gdfh; // nera minusiniu reiksmiu kaip suprantu
            ulong gfdhh;

            Console.WriteLine("Iveskite float");  // cw 2x tab is auto imete
            var floata = Convert.ToSingle(Console.ReadLine()); // eta float

            Console.WriteLine("Iveskite rida");  // cw 2x tab is auto imete
            var rida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciuka");  // cw 2x tab is auto imete
            var Skaiciuks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite Data");  // cw 2x tab is auto imete
            var Data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Rida: " + rida);
            Console.WriteLine("Skaiciuks: " + Skaiciuks);
            Console.WriteLine("Data: " + Data);

            Math.Round(Blabla, 3); // KIEK SKAICIU PO KABLELIO

            Convert.ToBoolean; // y boola convertina

            Console.Read(); // Nuskaito pirma raide ir pavercia skaiciumi ar kazkas tokio pagal lentele

            var gg = Console.Read();
            Console.WriteLine(gg); // raide pavercia skaicium
            Console.WriteLine((char)gg); // raide pavercia raide

            var jj = (char)Console.Read();
            var hhhh = Console.ReadLine();
            Console.WriteLine(jj);
            Console.WriteLine(hhhh);

            // gnfdsjfdjfdbgfdbjfdsbgjdsbjfdsbjgfzd;zsf
    


            var hgfjfj = Convert.ToChar(Console.ReadKey().KeyChar); // nereik paspaust enter po ivedimo OPPP ivedi ka praso ir JAIII iskart


        }
    }
}
