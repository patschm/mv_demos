using System;
using Masevon;

namespace DeFabriek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Big bang
            var lp = new TL();
            //.intensiteit = -200;
            //lp.SetIntensiteit(200);
            lp.Kleur = ConsoleColor.Yellow;
            lp.Intensiteit = 300;
            lp.Aan();

            var lp2 = new TL { Intensiteit = 700, Kleur = ConsoleColor.Red };
            //lp2.SetIntensiteit(-500);
            lp2.Aan();

            Lamp t1 = new TL { Kleur = ConsoleColor.Yellow, StarterTijd = 500 };
            if (t1 is TL)
            {
                TL t2 = t1 as TL;
                Console.WriteLine(t1 == t2);
                t2.StarterTijd = 300;
            }
            t1.Aan();
            




            // Big crunch
        }
    }
}
