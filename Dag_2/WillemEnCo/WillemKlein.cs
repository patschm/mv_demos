using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillemEnCo
{

    delegate int MatDel(int k, int x);


    class WillemKlein
    {
        public void Rekenuit(MatDel calc, int a, int b)
        {
            Console.WriteLine("Willem gaat rekenen");
            int result = calc(a,b);


            Console.WriteLine($"Willem is klaar en zegt dat het antwoord {result} is");
        }
    }
}
