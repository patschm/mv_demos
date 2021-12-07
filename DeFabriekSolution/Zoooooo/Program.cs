using System;
using Zoooooo.Dieren;
using Zoooooo.Verblijven;

namespace Zoooooo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dierentuin zoo = InitZoo();
            zoo.Start();
        }

        private static Dierentuin InitZoo()
        {
            Dierentuin zoo = new Dierentuin();
            Verblijf hok = new Kooi();
            zoo.Add(hok);
            OpSafarie(hok);

           Verblijf aqua  = new Aquarium();
            zoo.Add(aqua);
            Hengelen(aqua);

            foreach(Dier item in aqua)
            {
                item.MaakGeluid();
            }

            return zoo;
        }

        private static void Hengelen(Verblijf aqua)
        {
            var zebra = new ZebraVis();
            aqua[0] = zebra;//.Add(zebra);
            var sidder = new Sidderaal();
            aqua[1] = sidder;
        }

        private static void OpSafarie(Verblijf hok)
        {
            var tijgert = new Tijger();
            hok.Add(tijgert);
            var simba = new Leeuw();
            hok.Add(simba);
            var bzzt = new Sidderaal();
            hok.Add(bzzt);
        }
    }
}
