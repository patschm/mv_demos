using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRadio
{
    delegate void OntvangsMethode(string bericht);

    class Station
    {
        //private OntvangsMethode _Onvangers;


        public event OntvangsMethode Onvangers;
        //{
        //    add
        //    {
        //        _Onvangers += value; 
        //    }
        //    remove
        //    {
        //        _Onvangers -= value;
        //    }
        //}

        public void NarrowCast()
        {
            Onvangers("Hallo allemaal");
        }
    }
}
