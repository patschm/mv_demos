using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoooooo.Dieren;

namespace Zoooooo.Verblijven
{
    abstract class Verblijf : IEnumerable
    {
        private List<Dier> _dieren = new List<Dier>();

        public Dier this[int idx]
        {
            set
            {
                if (Check(value))
                {
                    _dieren.Add(value);
                }
            }
            get
            {
                return _dieren[idx];
            }
        }

        public void Add(Dier d)
        {
            if (Check(d))
            {
                _dieren.Add(d);
            }
        }

        protected abstract bool Check(Dier d);
        public void Shake()
        {
            foreach(Dier d  in _dieren)
            {
                d.MaakGeluid();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_dieren);
        }
    }

    class MyEnumerator : IEnumerator
    {
        private List<Dier> dieren;
        int idx = -1;
        internal MyEnumerator(List<Dier> dieren)
        {
            this.dieren = dieren;
        }
        public object Current => dieren[idx];

        public bool MoveNext()
        {

            idx++;
            return idx <dieren.Count;
        }

        public void Reset()
        {
            idx = -1;
        }
    }

}
