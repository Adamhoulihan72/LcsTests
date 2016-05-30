namespace Contracts.Writers
{
    using System.Collections.Generic;

    using Models;

    public interface IPersonWriter
    {
        int SavePerson(Person person);
        
    }
}
