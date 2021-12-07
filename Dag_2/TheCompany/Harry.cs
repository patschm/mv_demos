using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Harry : Persoon
    {
        public void Programmeert()
        {
            Console.WriteLine("Harry programmeert");
        }

        public override void Werken()
        {
            Programmeert();
        }
    }
}
