using System;

namespace Drukkamer
{
    class Program
    {
        static void Main(string[] args)
        {
            VacuumKamer chamber = new VacuumKamer();
            chamber.SetPressure(150_000);
            chamber.ShowInfo();
        }
    }
}
