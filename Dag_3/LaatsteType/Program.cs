using System;
using System.Diagnostics;
using System.Text;

namespace LaatsteType
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder s = new StringBuilder();
            string s = "";
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < 100000; i++)
            {
                s += i;
               // s.Append(i);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);


            Point p1 = new Point { X = 10, Y = 20 };
            Console.WriteLine(p1);
            DoeIets(p1);
            Console.WriteLine(p1);
            Console.ReadLine();
        }

        private static void DoeIets(Point bla)
        {
            bla.X = 100;
            bla.Y = 200;
        }
    }
}
