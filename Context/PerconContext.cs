using JurnalTZ.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalTZ.Context
{
    public class PerconContext : DbContext
    {
        DbSet<Person> Persons {  get; set; }

        public PerconContext() : base("MyDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(p => p.Name)
                .IsRequired();
        }
    }
}
