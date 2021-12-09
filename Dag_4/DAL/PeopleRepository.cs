using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PeopleRepository
    {
        private List<Person> _people;

        public List<Person> GetAll()
        {
            return _people;
        }
        public Person Insert(Person p)
        {
            _people.Add(p);
            p.Id = _people.Max(p => p.Id) + 1;
            return p;
        }
        public PeopleRepository()
        {
            _people = new Faker<Person>()
                .RuleFor(p => p.Id, fk => fk.UniqueIndex)
                .RuleFor(p => p.Firstname, fk => fk.Name.FirstName())
                .RuleFor(p => p.Lastname, fk => fk.Name.LastName())
                .RuleFor(p => p.Age, fk => fk.Random.Number(0, 123))
                .Generate(50)
                .ToList();
        }
    }
}
