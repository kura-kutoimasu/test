using Entities.Data.Models;
using System.Collections.Generic;
namespace Entities.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Person GetPerson(int id);
        IEnumerable<Person> GetAllPersons();
        Person Add(Person person);
        Person Update(Person personchanges);
        Person Delete(int id);
    }
}
