using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukkamer
{
    class Klep
    {
        private bool _isOpen;
        private bool _isDicht;

        public void Open()
        {
            Console.WriteLine("Klep gaat open");
            _isOpen = true;
            _isOpen = false;
        }
        public void Dicht()
        {
            Console.WriteLine("Klep gaat dicht");
            _isDicht = true;
            _isOpen = false;
        }
    }
}
