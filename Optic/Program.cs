using System;
using System.Data.Entity;
using System.Linq;
using Optic.Data;
using Optic.Business;
using Optic.DataAccess.DTOs;

namespace Optic
{
    class Program
    {
        //CarManager carManager = new CarManager();
        
        static void Main(string[] args)
        {
            Program pgm = new Program();
            // JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;
            Database.SetInitializer<Context>(null);
            //Console.WriteLine(pgm.GetCarTypeName());
            Console.ReadLine();
        }

        //private string GetCarTypeName()
        //{
        //    return carManager.GetCarTypeNameByCarId(1);
        //}

        //private void CreateCar()
        //{
        //    var newCar = new CarDTO
        //    {
        //        CarTypeID=2,
        //        Name="Zen",
        //        Number="Z123",
        //        Owner=new PersonDTO
        //        {
        //            Id=1
        //        }
        //    };
        //}
    }
}
