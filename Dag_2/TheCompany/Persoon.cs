using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    abstract class Persoon : IContract
    {
        public void Produceer()
        {
            Werken();
        }

        public abstract void Werken(); 
    }
}
