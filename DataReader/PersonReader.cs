using DataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader
{
    using Contracts.Readers;

    using Models;

    public class PersonReader : IPersonReader
    {
        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}
