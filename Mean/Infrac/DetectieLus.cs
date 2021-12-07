using Interfaces;
using System;
using System.Collections.Generic;

namespace Infrac
{
    public class DetectieLus
    {
        private List<IActivator> devices = new List<IActivator>();

        public void Connect(IActivator device)
        {
            devices.Add(device);
        }
        public void Detecteer()
        {
            Console.WriteLine("De detectielus detecteert iets");
            foreach(IActivator device in devices)
            {
                device.Activate();
            }
        }
    }
}
