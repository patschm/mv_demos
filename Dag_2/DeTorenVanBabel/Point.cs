using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTorenVanBabel
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator+(Point a, Point b)
        {
            return new Point { X = a.X + b.X, Y = a.Y + b.Y };
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
