using Interfaces;
using System;

namespace Philips
{
    public class Lamp: IActivator
    {
        public void Aan()
        {
            Console.WriteLine("De lamp gaat aan");
        }

        public void Activate()
        {
            Aan();
        }
    }
}
