using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    namespace ContosoUniversity.DAL
    {
        using Models;

        public class SchoolContext : DbContext
        {

            public SchoolContext() : base("DefaultConnection")
            {
            }

            public DbSet<Person> Students { get; set; }
            
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}
