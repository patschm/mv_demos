using System;

namespace Vullis
{
    class Program
    { 
        static Rommel puin1 = new Rommel();
        static Rommel puin2 = new Rommel();

        static void Main(string[] args)
        {

            try
            {
                puin1.Open();
            }
            finally
            {
                puin1.Dispose();
            }
            
            puin1 = null;
            //int gen = GC.GetGeneration(puin1);
            //Console.WriteLine(gen);

           // GC.Collect();
            //GC.WaitForPendingFinalizers();

            //gen = GC.GetGeneration(puin1);
            //Console.WriteLine(gen);

            using (puin2)
            {
                puin2.Open();
            }
            puin2 = null;

            using (Rommel puin3 = new Rommel())
            {
                puin3.Open();
            }

            Console.ReadLine();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
