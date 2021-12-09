using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threadings
{
    class Program
    {
        static void Main(string[] args)
        {
            //ViaAPM();
            //ViaTask();
            //MetFouten();
            //Cancellen();
            //HetWordtNogMooier();
            //HetWordtNogMooier();
            //Bla();
            //MoreFunAsync();
            //Synchen();
            // SemaphoreDemo();
            BackgroundWorkerDemo();


            ThreadStart ts = new ThreadStart(() => { 
                Console.WriteLine("Hello Thread"); 
            });
            Thread thr = new Thread(ts);
            thr.Start();

            
            //thr.IsBackground = true;

            List<int> list = new List<int>();

            ConcurrentBag<int> list2 = new ConcurrentBag<int>();
            list2.Add(4);
            list2.ToList();

            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        private static void BackgroundWorkerDemo()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
        }

        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Doe Iets");

        }

        private static void SemaphoreDemo()
        {
            Random rnd = new Random();
            ManualResetEventSlim zaklamp = new ManualResetEventSlim(false);
            Semaphore garage = new Semaphore(5, 5);

            int idx = 0;
            for (int i = 0; i < 20; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine($"Auto {Thread.CurrentThread.ManagedThreadId} is gestart");

                    zaklamp.Wait();

                    Console.WriteLine($"Auto {Thread.CurrentThread.ManagedThreadId} staat voor de garage");
                    garage.WaitOne();
                    Console.WriteLine($"Auto {Thread.CurrentThread.ManagedThreadId} rijdt nu de garage in");
                    Task.Delay(5000 + 1000 * rnd.Next(1, 10)).Wait();
                    garage.Release();
                    Console.WriteLine($"Auto {Thread.CurrentThread.ManagedThreadId} rijdt de garage uit");
                });
            }

            Console.ReadLine();
            zaklamp.Set();
        }

        static object stokje = new object();

        private static void Synchen()
        {
            int a = 0;

            Parallel.For(0, 20, idx =>
            {
                //Monitor.Enter(stokje);
                Console.WriteLine($"Task {idx}");
                lock (stokje)
                {
                    int tmp = a;
                    Task.Delay(2000).Wait();

                    Console.WriteLine(++tmp);
                    a = tmp;
                }
                //Monitor.Exit(stokje);
            });

            Console.WriteLine(a);

        }

        private static async Task MoreFunAsync()
        {

            AutoResetEvent zaklamp = new AutoResetEvent(false);
            zaklamp.Set();
            int a = 0;
            int b = 0;

            var t1 = Task.Run(() =>
            {
                Task.Delay(3000).Wait();
                a = 40;
            });
            var t2 = Task.Run(() =>
            {
                Task.Delay(2000).Wait();
                b = 20;
            });

            await Task.WhenAny(t1, t2);
            int res = a + b;
            Console.WriteLine(res);
        }

        private static async void HetWordtNogMooier()
        {
            try
            {
                await Task.Run(() =>
                {
                    Console.WriteLine("Gaan we dan");
                    Task.Delay(1000).Wait();
                    throw new Exception("Ooops");
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Task<int> t2 = new Task<int>(() => LongAdd(14, 15));
            t2.Start();

            int result = await t2;
            Console.WriteLine(result);

            result = await Task.Run<int>(() => LongAdd(6, 7));
            Console.WriteLine(result);

            result = await LongAddAsync(34, 8);
            Console.WriteLine(result);
        }

        private static void Cancellen()
        {
            CancellationTokenSource nikko = new CancellationTokenSource();

            CancellationToken bommetje = nikko.Token;

            Task.Run(() =>
            {
                do
                {
                    if (bommetje.IsCancellationRequested)
                    {
                        Console.WriteLine("Bye bye");
                        return;
                    }
                    Console.WriteLine("Hoi");
                    Task.Delay(100).Wait();
                }
                while (true);
            });


            Task.Delay(5000).ContinueWith(pt => nikko.Cancel());
            //nikko.Cancel();
            //nikko.CancelAfter(4000);
        }

        private static void MetFouten()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Gaan we dan");
                Task.Delay(1000).Wait();
                throw new Exception("Ooops");
            }).ContinueWith(pt =>
            {
                if (pt.Exception != null)
                {
                    Console.WriteLine(pt.IsFaulted);
                    Console.WriteLine(pt.Exception.InnerException.Message);
                }
            });

        }

        private static void ViaTask()
        {
            //Task t1 = new Task(()=> {
            //    int result = LongAdd(3, 4);
            //    Console.WriteLine(result);
            //});
            //t1.Start();

            Task<int> t2 = new Task<int>(() => LongAdd(4, 5));
            t2.ContinueWith(vorigeTaak =>
            {
                Console.WriteLine(vorigeTaak.Result);
            }).ContinueWith(pt => Console.WriteLine("Tweede"));

            //t2.Start();

            Task.Run<int>(() => LongAdd(6, 7)).ContinueWith(vorigeTaak =>
            {
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
            // Console.WriteLine(tx.Result);
        }

        static async void Bla()
        {
            Console.WriteLine("Hoi");
        }
        static int LongAdd(int a, int b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
        static Task<int> LongAddAsync(int a, int b)
        {
            return Task.Run(() => LongAdd(a, b));
        }
    }
}
