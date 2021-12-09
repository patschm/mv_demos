using System;
using System.Diagnostics;

namespace Fouten
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Geef een getal");
                string data = Console.ReadLine();

                try
                {
                    int nr = int.Parse(data);
                    Console.WriteLine(nr);
                    return;
                }
                catch(FormatException fe)
                {
                    Debug.WriteLine(fe.Message);
                    Debug.WriteLine(fe.StackTrace);
                    Console.WriteLine("Fout. Probeer het nog eens");
                }
                catch(OverflowException oe)
                {
                    Debug.WriteLine(oe);
                    Console.WriteLine($"Getal moet tussen {int.MinValue} en {int.MaxValue} liggen");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Wordt altijd uitgevoerd");
                }
            }
            while (true);

        }

        static double BL(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                throw;// new Exception("Delen door 0 is flauwekul");
            }
        }
    }
}
