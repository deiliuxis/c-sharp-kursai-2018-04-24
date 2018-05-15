using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02_su_file2
{
    class Gyvunai
    {
        public string Rusis { get; set; }
        public string Pavadinimas { get; set; }
        public int Amzius { get; set; }
        public string Vardas { get; set; }

        public Gyvunai(string rusis,string pavadinimas, int amzius, string vardas)
        {

            Rusis = rusis;
            Pavadinimas = pavadinimas;
            Amzius = amzius;
            Vardas = vardas;
        }

        public Gyvunai(string eilute)
        {
            var duomenys = eilute.Split(';');
            Rusis = duomenys[0];
            Pavadinimas = duomenys[1];
            Amzius = Convert.ToInt32(duomenys[2]);
            Vardas = duomenys[3];
        }
    }
}
