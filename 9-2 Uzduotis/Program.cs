using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Tinka = true;
            for (int a = 1; true ; a++)
            {

                for (int i = 1; i <=20; i++)
                {
                    if (a % i != 0)
                    {
                        Tinka = false;
                        break;
                    }


                }
                if (Tinka == true)
                {
                    Console.WriteLine(a);
                    break;

                }

                Tinka = true;
            }
        }


    }
}
