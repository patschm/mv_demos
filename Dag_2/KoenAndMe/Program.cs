using System;

namespace KoenAndMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new Patrick();
            Koen k = new Koen();

            k.Execute(p.Instructies);

            k.Execute(Explode);
        }

        static int Explode()
        {
            Console.WriteLine("Kaboooom!!!");
            return 42;
        }
    }
}
