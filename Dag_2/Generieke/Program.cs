using System;
using System.Collections.Generic;

namespace Generieke
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();


            AutoFabriek<DafTurbo> weert = new AutoFabriek<DafTurbo>();
            DafTurbo t1 = weert.Create();


            uint xxx = 9;
            float f = xxx;
            //decimal a = 10.5M;
            //decimal b = 20.9M;

            DafTurbo a = new DafTurbo { Val = 3 };
            DafTurbo b = new DafTurbo { Val = 4 };

            Console.WriteLine($"a={a.Val}, b={b.Val}");
            Swap<DafTurbo>(ref  a, ref b);
            Console.WriteLine($"a={a.Val}, b={b.Val}");
        }

        private static void Swap<T>(ref T aaa, ref T bbb)
        {
            T tmp = aaa;
            aaa = bbb;
            bbb = tmp;
        }
        //private static void Swap(ref double aaa, ref double bbb)
        //{
        //    double tmp = aaa;
        //    aaa = bbb;
        //    bbb = tmp;
        //}
        //private static void Swap(ref decimal aaa, ref decimal bbb)
        //{
        //    decimal tmp = aaa;
        //    aaa = bbb;
        //    bbb = tmp;
        //}
    }
}
