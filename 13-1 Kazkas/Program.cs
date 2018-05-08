using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Kazkas
{

    class Program
    {
        static void Main(string[] args)
        {
            var prieglauda = new Priglauda("Septinta koja","gfdh",new List<Suo>
            {
                new Suo("pirmas","Haskis",20),
                new Suo("antras","Spanielis",12),
                new Suo("trecias","Terjeras",9),
                new Suo("ketvirtas","Pudelis",11)
            });

            prieglauda.Isvedimas();
            prieglauda.Checkin();
            prieglauda.Isvedimas();
        }
    }
}
