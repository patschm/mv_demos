using System;

namespace EvolutieTheorieDerDelegates
{
    delegate int MatDel(int k, int x);

    class Program
    {
        static MatDel d5;

        static void Main(string[] args)
        {
            int result = 0;
           
            // .NET 1.0-1.1
            MatDel d1 = new MatDel(Add);
            result = d1(1, 2);

            // .NET 2.0
            MatDel d2 = Add;
            result = d2(2, 3);

            int c = 10;
            MatDel d3 = delegate (int a, int b)
             {
                 return a + b + c;
             };
            result = d3(3, 4);

            // .NET 3.0
            MatDel d4 = (a,  b) => a + b;
            result = d4(4, 5);

            // Procedures
            Action<int, int> a1 = (int a, int b) => Console.WriteLine("Nice" + a);
            a1(42, 5);

            // Functions
            Func<int, int, int> d6 = Add;
            result = d6(5, 6);

            // Predicate voor booleaanse functions
            Predicate<int> pr1 = a => a == 42;

            Console.WriteLine(pr1(43));

            Console.WriteLine(result);

            Console.WriteLine(result);

            // C# 8
            int LocalAdd(int a, int b)
            {
                return a + b + c;
            }


            Console.WriteLine(LocalAdd(3,4));
        }


         static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
