using System;
using Masevon;

namespace DeFabriek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Big bang
            var lp = new Lamp(300);
            //.intensiteit = -200;
            //lp.SetIntensiteit(200);
            lp.Kleur = ConsoleColor.Yellow;
            lp.Intensiteit = 300;
            lp.Aan();

            var lp2 = new Lamp { Intensiteit = 700, Kleur = ConsoleColor.Red };
            //lp2.SetIntensiteit(-500);
            lp2.Aan();
       





            // Big crunch
        }
    }
}
