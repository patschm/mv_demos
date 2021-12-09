using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Services
{
    public class Teller
    {
        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        public void Increment()
        {
            Counter++;
            Console.WriteLine(Counter);
        }
    }
}
