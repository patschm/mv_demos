using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Bokito : IContract, IContract2
    {
        public void Produceer()
        { 
            Console.WriteLine("Bokito peert irritante klanten in elkaar");
        }
        void IContract2.Produceer()
        {

        }
    }
}
