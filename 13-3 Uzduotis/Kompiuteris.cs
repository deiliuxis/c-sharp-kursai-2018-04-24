using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_Uzduotis
{
    class Kompiuteris
    {
        // prop arba propg
        public string Vaizduske { get; private set; }
        public string Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }

        public Kompiuteris(string vaizduske, string motinine, int diskoTalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskoTalpa;

        }

        public Kompiuteris()
        {

        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite vaizduskes pavadinima");
            Vaizduske = Console.ReadLine();
            Console.WriteLine("Iveskite motinines pavadinima");
            Motinine = Console.ReadLine();
            Console.WriteLine("Iveskite disko talpa");
            DiskoTalpa = Convert.ToInt32(Console.ReadLine());
        }

        public void Isvedimas()
        {
            Console.WriteLine("Kompiuterio info: vaizduske: {0}, motinine: {1}, disko talpa: {2}",Vaizduske,Motinine,DiskoTalpa);



        }
    }
}
