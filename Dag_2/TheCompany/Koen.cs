using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Koen : Persoon, IContract
    {
        public void KanIets()
        {
            Console.WriteLine("Koen doet iets");
        }

        //public void Produceer()
        //{
        //    KanIets();
        //}

        public override void Werken()
        {
            KanIets();
        }
    }
}
