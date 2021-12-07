using Interfaces;
using System;

namespace AbcHekwerken
{
    public class Hek: IActivator
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("Hek gaat open");
        }
    }
}
