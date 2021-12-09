using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Basics.Models
{
    public class FakePersonRepository : IPersonRepository
    {
        private List<Person> _people;
        public FakePersonRepository()
        {
            _people = new Bogus.Faker<Person>()
                .RuleFor(p => p.Id, fk => fk.IndexGlobal)
                .RuleFor(p => p.FirstName, fk => fk.Name.FirstName())
                .RuleFor(p => p.LastName, fk => fk.Name.LastName())
                .RuleFor(p => p.Age, fk => fk.Random.Number(0, 123))
                .RuleFor(p => p.FavoriteColor, fk => fk.Commerce.Color())
                .Generate(100)
                .ToList();
        }
        public List<Person> Get(int start = 0, int amount = 10)
        {
            return _people.Skip(start).Take(amount).ToList();
        }
        public Person Get(int id)
        {
            return _people.Find(p => p.Id == id);
        }
        public int Post(Person p)
        {
            p.Id = ++Bogus.Faker.GlobalUniqueIndex;
            _people.Add(p);
            return p.Id;
        }
        public void Put(Person p)
        {
            var dbp = _people.Find(px => px.Id == p.Id);
            dbp.FirstName = p.FirstName;
            dbp.LastName = p.LastName;
            dbp.Age = p.Age;
            dbp.FavoriteColor = p.FavoriteColor;
        }
        public void Delete(int id)
        {
            var dbp = _people.Find(px => px.Id == id);
            _people.Remove(dbp);
        }

    }
}
