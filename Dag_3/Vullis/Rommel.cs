using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vullis
{
    class Rommel : IDisposable
    {
        private static bool _isOpen = false;

        public void Open()
        {
            if (!_isOpen)
            {
                Console.WriteLine("Open");
                _isOpen = true;
            }
            else
                Console.WriteLine("Helaas");
        }
        public void Close()
        {
            Console.WriteLine("Closing...");
            _isOpen = false;
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        ~Rommel()
        {
            Close();
        }
    }
}
