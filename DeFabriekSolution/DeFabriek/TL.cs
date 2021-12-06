using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masevon
{
    class TL : Lamp
    {
        public int StarterTijd { get; set; } = 200;

        public void Knipper()
        {
            Console.WriteLine("De TL Knippert");
        }
        public override void Aan()
        {
            base.Aan();
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De TL knippert {StarterTijd} ms en gaat aan met een intensiteit van {Intensiteit} lumen");
            Console.ResetColor();
        }
    }
}
