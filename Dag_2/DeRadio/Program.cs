using System;

namespace DeRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            Station r538 = new Station();
            r538.Onvangers += ViaSms;
            r538.Onvangers += ViaTamtam;
            r538.Onvangers += ViaRooksignalen;
            r538.Onvangers += ViaEther;
            r538.Onvangers += ViaSms;
            r538.Onvangers += ViaPostduif;
            r538.Onvangers += ViaRooksignalen;
            r538.Onvangers += ViaEther;
            r538.Onvangers += ViaSms;
            r538.Onvangers += ViaTamtam;
            r538.Onvangers += ViaRooksignalen;
            r538.Onvangers += ViaEther;

            //r538.Onvangers("Heya!!!");
            r538.NarrowCast();
        }

        static void ViaSms(string data)
        {
            Console.WriteLine($"Via SMS: {data}");
        }
        static void ViaEther(string data)
        {
            Console.WriteLine($"Via Ether: {data}");
        }
        static void ViaPostduif(string data)
        {
            Console.WriteLine($"Via Postduif: {data}");
            //throw new Exception("oops");
        }
        static void ViaRooksignalen(string data)
        {
            Console.WriteLine($"Via Rooksignalen: {data}");
        }
        static void ViaTamtam(string data)
        {
            Console.WriteLine($"Via Tamtam: {data}");
        }
    }
}
