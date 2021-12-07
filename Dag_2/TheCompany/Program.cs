using System;

namespace TheCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Harry h = new Harry();
            Koen k = new Koen();
            Ewoud ew = new Ewoud();
            Bokito b = new Bokito();

            ACME acme = new ACME();

            acme.Hire(ew);
            acme.Hire(k);
            acme.Hire(b);

            acme.Start();
        }
    }
}
