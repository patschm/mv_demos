using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    interface IContract2
    {
        void Produceer();
    }
    interface IContract
    {
        void Produceer();
    }

    class ACME
    {
        private List<IContract> personen = new List<IContract>();

        public void Hire(IContract p)
        {
            personen.Add(p);
        }

        public void Start()
        {
            Console.WriteLine("ACME gaat nu produceren");
            foreach (IContract p in personen) p.Produceer();
        }
    }
}
