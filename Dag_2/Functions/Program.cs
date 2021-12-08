using Bogus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static bool FirstNameStartsWithAK(Person p)
        {
            return p.Firstname.StartsWith("K");
        }
        static bool FirstNameStartsWithAnS(Person p)
        {
            return p.Firstname.StartsWith("S");
        }
        static void Main(string[] args)
        {
            List<Person> people = new Faker<Person>()
                .RuleFor(p => p.Firstname, fk => fk.Name.FirstName())
                .RuleFor(p => p.Lastname, fk => fk.Name.LastName())
                .RuleFor(p => p.Age, fk => fk.Random.Number(0, 123))
                .Generate(1000)
                .ToList();


            string q2 = "SELECT * FROM people WHERE FirstName = 'g'";
            q2 += " And LastName = 's'";

            string first = Console.ReadLine();

            var qq = from p in people where p.Firstname.StartsWith(first) select p;

            var query = people.Where(p =>p.Firstname.StartsWith(first));
            query = qq.Where(p => p.Lastname.StartsWith("S"));

            foreach(Person p in query)
            {
                Console.WriteLine($"{p.Firstname} {p.Lastname} ({p.Age})");
            }


            Form f1 = new Form();
            f1.Text = "Hoi";

            Button btn = new Button();
            btn.Location = new Point { X = 100, Y = 200 };
            btn.Click += Bla;
            btn.Text = "OK";

            f1.Controls.Add(btn);
           // f1.ShowDialog();

            Console.ReadLine();
        }

        static void Bla(object sender, EventArgs e)
        {
            Console.WriteLine("Blaablabla");
        }
    }
}
