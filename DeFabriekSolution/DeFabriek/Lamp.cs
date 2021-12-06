using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masevon
{
    // Blauwdruk van de lamp
    // Type Definitie
    class Lamp
    {
        // Fields. Hierin slaan we eigeschappen op.
        private int _intensiteit = 100;

        // Auto generating property. Die neemt zijn eige field mee
        public ConsoleColor Kleur { get; set;}

        // Properties. Hiermee geeft men gecontroleerde toegang tot fields
        public int Intensiteit
        {
            get
            {
                return _intensiteit;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    _intensiteit = value;
                }
            }
        }

        // Gedrag leg je vast in Methods
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp gaat aan met een intensiteit van {Intensiteit} lumen");
            Console.ResetColor();
        }

        // Constructors. Bedoeld om fields een initiele waarde te geven
        public Lamp(int lumen)
        {
            Intensiteit = lumen;
        }
        public Lamp() : this(200)
        {
            
        }
    }
}
