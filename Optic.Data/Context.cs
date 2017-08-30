using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using Optic.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Optic.Data
{
   public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        { }
        public IDbSet<TEntity> SetNew<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Switch off Pluralizing Table Names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
        

        public DbSet<MasterType> MasterType { get; set; }
        public DbSet<OpticMasters> OpticMasters { get; set; }
        public DbSet<VendorMaster> VendorMasters { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>()
        //        .HasMany(x => x.OwnedCar)
        //        .WithOptional(y => y.Owner);
        //}
    }
}
