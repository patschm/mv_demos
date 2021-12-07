using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoooooo.Verblijven;

namespace Zoooooo
{
    class Dierentuin
    {
        private List<Verblijf> _verblijven = new List<Verblijf>();

        public List<Verblijf> Verblijven
        {
            get
            {
                return _verblijven;
            }
        }
        public void Add(Verblijf vb)
        {
            _verblijven.Add(vb);
        }
        public void Start()
        {
            foreach(Verblijf vb in _verblijven)
            {
                vb.Shake();
            }
        }
    }
}
