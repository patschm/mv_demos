using System;

namespace DeTorenVanBabel
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Hoi";
           string res =  s.SponsoredBy("Patrick");
            Console.WriteLine(res);

            Point p1 = new Point { Y = 20, X = 10 };
            Point p2 = new Point { Y = 200, X = 100 };

            Point p3 = p1 + p2;
            Console.WriteLine(p3);


            Etage[] babelseToren = new Etage[50];
            for(var i = 0; i < babelseToren.Length; i++)
            {
                babelseToren[i] = new Etage { FloorNumber = i };
            }

            babelseToren[34].CallElevator();

            foreach (var item in babelseToren)
            {
                //item.ShowElevatorStatus();
            }
        }
    }
}
