using Optic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(Context context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new Context();
            //carRepository = new Repository<Car>(context);
            //carTypesRepository=new Repository<CarType> (context);
            //personRepository= new Repository<Person>(context);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public Repository<T> Repository<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<T>)repositories[type];
        }

        #region Repositories
        public Repository<Car> carRepository { get
            {
                return new Repository<Car>(context);
            }
            set
            {
                carRepository = value;
            }
        }
        public Repository<CarType> carTypesRepository
        {
            get
            {
                return new Repository<CarType>(context);
            }
            set
            {
                carTypesRepository = value;
            }
        }
        public Repository<Person> personRepository
        {
            get
            {
                return new Repository<Person>(context);
            }
            set
            {
                personRepository = value;
            }
        }

        public Repository<MasterType> masterTypeRepository
        {
            get
            {
                return new Repository<MasterType>(context);
            }
            set
            {
                masterTypeRepository = value;
            }
        }
        public Repository<OpticMaster> opticMasterRepository
        {
            get
            {
                return new Repository<OpticMaster>(context);
            }
            set
            {
                opticMasterRepository = value;
            }
        }
        public Repository<VendorMaster> vendorMasterRepository
        {
            get
            {
                return new Repository<VendorMaster>(context);
            }
            set
            {
                vendorMasterRepository = value;
            }
        }

        #endregion
    }
}
