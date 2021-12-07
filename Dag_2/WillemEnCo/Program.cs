using System;

namespace WillemEnCo
{
    class Program
    {
        static void Main(string[] args)
        {
            WillemKlein wk = new WillemKlein();
            SimonVDMeer svdm = new SimonVDMeer();
            //wk.Rekenuit(svdm.Add, 4,5);
            //wk.Rekenuit(svdm.Subtract, 20, 10);

            int a = 10;
            MatDel del = svdm.Add;
            del = del + svdm.Add + svdm.Subtract;// - svdm.Add - svdm.Subtract;

            foreach(var item in del.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            int res = del(1, 2);

            Console.WriteLine(res);

        }
    }
}
