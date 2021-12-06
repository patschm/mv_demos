using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukkamer
{
    class VacuumKamer
    {
        private Klep atmKlep = new Klep();
        private Klep vacKlep = new Klep();

        private int pressure = 100_000;
        private float temperature = 293;

        public int Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                if (value > 0)
                {
                    pressure = value;
                }
            }
        }

        public void SetPressure(int targetP)
        {
            if (targetP >= 100_000)
            {
                vacKlep.Open();
                atmKlep.Dicht();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Temp: {temperature}K, Pressure: {pressure}Pa");
        }
    }
}
