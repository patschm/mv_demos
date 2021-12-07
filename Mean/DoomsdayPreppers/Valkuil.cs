using Interfaces;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil: IActivator
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("De valkuil met scherpe spiezen opent");
        }
    }
}
