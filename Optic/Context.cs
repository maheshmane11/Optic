using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace JetEFDemo
{
    class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        { }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>()
        //        .HasMany(x => x.OwnedCar)
        //        .WithOptional(y => y.Owner);
        //}
    }
}
