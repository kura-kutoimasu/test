using Services.Person.Interfaces;
using System.Collections.Generic;

namespace Services.Person
{
    public class PersonService : IPersonService
    {
        Entities.Repositories.Interfaces.IPersonRepository _personRepository;
        public PersonService(Entities.Repositories.Interfaces.IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public IEnumerable<Entities.Data.Models.Person> GetAll()
        {
            return _personRepository.GetAllPersons();
        }
    }
}
