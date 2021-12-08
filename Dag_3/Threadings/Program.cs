using System;
using System.Threading.Tasks;

namespace Threadings
{
    class Program
    {
        static void Main(string[] args)
        {
           //ViaAPM();
           /ViaTask();
            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        private static void ViaTask()
        {
            //Task t1 = new Task(()=> {
            //    int result = LongAdd(3, 4);
            //    Console.WriteLine(result);
            //});
            //t1.Start();

            Task<int> t2 = new Task<int>(() => LongAdd(4,5));
            t2.ContinueWith(vorigeTaak => {
                Console.WriteLine(vorigeTaak.Result);
            }).ContinueWith(pt => Console.WriteLine("Tweede"));

            //t2.Start();

            Task.Run<int>(()=>LongAdd(6,7)).ContinueWith(vorigeTaak => {
                Console.WriteLine(vorigeTaak.Result);
            }).ContinueWith(pt => Console.WriteLine("Tweede"));



            //void DoeIets()
            //{
            //    int result = LongAdd(3, 4);
            //    Console.WriteLine(result);
            //}
        }

        private static void ViaAPM()
        {
            Func<int, int, int> fn = LongAdd;
           // Task<int> tx = Task<int>.Factory.FromAsync(fn.BeginInvoke(6,7, null, null), fn.EndInvoke);

            //IAsyncResult ar = fn.BeginInvoke(2, 3, ar=> {  
            //    int result = fn.EndInvoke(ar);
            //}, null);
            //
            Console.WriteLine(tx.Result);
        }

        static int LongAdd(int a, int b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
    }
}
