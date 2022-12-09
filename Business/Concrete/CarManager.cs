using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarServices
    {
        private ICarDal _carDal;
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (IsValid(car.Description, (double)car.DailyPrice))
            {
                _carDal.Add(car);
            }
        }

        public void Delete(int id)
        {
            _carDal.Delete(id);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAllCars();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);


        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(car => car.ColorId == colorId);
        }

        private bool IsValid(string carName, double dailyPrice)
        {
            if (carName != null && carName.Length > 1)
            {
                if (dailyPrice > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Daily price of the car can't be lower than 0 : " + dailyPrice);
                }
            }
            else
            {
                Console.WriteLine("Name of the car must contain at least 2 characters!");
            }
            return false;
        }
    }


}
