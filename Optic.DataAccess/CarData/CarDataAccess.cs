using Optic.Data;
using Optic.Data.Models;
using Optic.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess.CarData
{
    public class CarDataAccess
    {  
        public string GetCarTypeNameByCarId(int carId)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.carRepository.GetById(carId).CarType.CarTypeName.ToString();
            }
        }

        public void CreateNewCar(CarDTO newCarDto)
        {

            // Working Insert Code
            using (var unitOfWork = new UnitOfWork())
            {
                var newCar = new Optic.Data.Models.Car
                {
                    CarType = new CarType
                    {
                        CarTypeID = newCarDto.CarType.CarTypeID,
                        CarTypeName = newCarDto.CarType.CarTypeName
                    },
                    Name = newCarDto.Name,
                    Number = newCarDto.Number,
                    Owner = new Person
                    {
                        Id = newCarDto.Owner.Id,
                        Name = newCarDto.Owner.Name
                    }
                };

                unitOfWork.carRepository.Insert(newCar);
            }
        }
    }
}
