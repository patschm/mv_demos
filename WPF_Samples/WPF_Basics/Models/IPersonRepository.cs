using System.Collections.Generic;

namespace WPF_Basics.Models
{
    public interface IPersonRepository
    {
        void Delete(int id);
        List<Person> Get(int start = 0, int amount = 10);
        Person Get(int id);
        int Post(Person p);
        void Put(Person p);
    }
}