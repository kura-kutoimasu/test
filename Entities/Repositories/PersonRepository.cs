using Entities.Data.Models;
using Entities.Repositories.Interfaces;
using System.Collections.Generic;

namespace Entities.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PracticeDBContext context;

        public PersonRepository(PracticeDBContext context)
        {
            this.context = context;
        }
        public Person Add(Person person)
        {
            context.Person.Add(person);
            context.SaveChanges();
            return person;
        }

        public Person Delete(int id)
        {
            Person person = context.Person.Find(id);
            if(person != null)
            {
                context.Person.Remove(person);
                context.SaveChanges();
            }
            return person;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return context.Person;
        }

        public Person GetPerson(int id)
        {
            return context.Person.Find(id);
        }

        public Person Update(Person personchanges)
        {
            var person = context.Person.Attach(personchanges);
            person.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return personchanges;
        }
    }
}
