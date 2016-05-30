using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Readers
{
    using Models;

    public interface IPersonReader
    {
        Person GetPersonById(int id);

        IEnumerable<Person> GetAllPersons();
    }
}
