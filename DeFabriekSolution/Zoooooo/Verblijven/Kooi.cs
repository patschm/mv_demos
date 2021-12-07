using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoooooo.Dieren;

namespace Zoooooo.Verblijven
{
    class Kooi : Verblijf
    {
        protected override bool Check(Dier d)
        {
            return d is Kat;
        }
    }
}
