using AbcHekwerken;
using DoomsdayPreppers;
using Infrac;

using System;

namespace Oprijlaan
{
    class Program
    {
        static void Main(string[] args)
        {
            DetectieLus lus = new DetectieLus();
            Hek hek = new Hek();
            Valkuil kuil = new Valkuil();
            Philips.Lamp lamp = new Philips.Lamp();


            lus.Detecteer();


        }
    }
}
