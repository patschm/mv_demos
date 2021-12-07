using System;

namespace DeTorenVanBabel
{
    class Elevator
    {
        private int _currentFloor = 0;
        public int CurrentFloor
        {
            get
            {
                return _currentFloor;
            }
        }

        public void Call(int floor)
        {
            Console.WriteLine("Zoemmm");
            _currentFloor = floor;
        }

    }
}