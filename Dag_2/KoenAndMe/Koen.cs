using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoenAndMe
{
    delegate int DoeIetsDel();

    class Koen
    {
        private DoeIetsDel del;

        public void Execute(DoeIetsDel arg)
        {
            del = arg;
            Console.WriteLine("Koen doet nu:");
            int res = del();
        }
    }
}
