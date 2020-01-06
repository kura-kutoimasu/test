
using System.Collections.Generic;

namespace Services.Person.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Entities.Data.Models.Person> GetAll();
    }
}
