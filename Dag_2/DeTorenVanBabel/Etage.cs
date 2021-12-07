using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTorenVanBabel
{
    class Etage
    {
        private static Elevator lift = new Elevator();

        public int FloorNumber { get; set; } = 0;

        public void CallElevator()
        {
            Etage.lift.Call(FloorNumber);
        }
        public void ShowElevatorStatus()
        {
            //this.FloorNumber;
            //Etage.lift;
            Console.WriteLine($"De lift staat op de {lift.CurrentFloor}e verdieping");
        }
    }
}
