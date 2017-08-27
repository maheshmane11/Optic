using Optic.DataAccess.CarData;
using Optic.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Business
{
    public class CarManager
    {
        CarDataAccess carDataAccess = new CarDataAccess();
        public string GetCarTypeNameByCarId(int carId)
        { 
            return carDataAccess.GetCarTypeNameByCarId(carId);
        }

        public void CreateCar(CarDTO carDto)
        {
            carDataAccess.CreateNewCar(carDto);
        }
    }
}
