using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");

            var response = await client.GetAsync("people");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("OK");
                var body = await response.Content.ReadAsStringAsync();
                // Nuget Package Newtonsoft.Json
                var list = JsonConvert.DeserializeObject<List<Person>>(body);
                foreach(Person p in list)
                    Console.WriteLine($"[{p.Id}] {p.Firstname} {p.Lastname} ({p.Age})");
            }
        }
    }
}
