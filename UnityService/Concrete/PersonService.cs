using System.Collections.Generic;
using UnityService.Abstract;

namespace UnityService.Concrete
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "Gökhan", Surname = "Alkan" });
            persons.Add(new Person { Name = "Sedat", Surname = "Alkan" });

            return persons;
        }
    }
}
