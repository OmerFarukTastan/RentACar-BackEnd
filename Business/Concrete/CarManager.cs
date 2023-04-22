using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        
        public IResult Add(Car car)
        {
            
             _carDal.Add(car);
             return new SuccessResult(Messages.CarAdded);
            
            
        }

        public IResult Delete(Car Id)
        {
            _carDal.Delete(Id);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.Id == id), $"Car with id: {id} is listed");
        }

        public IDataResult<List<Car>> GetAll()
        {
            var data = _carDal.GetAll();
            var message = "All cars are listed";
            return new SuccessDataResult<List<Car>>(data, message);
        }

        public IResult Update(Car car)
        {
            var carName = car.Description;
            if (IsValid(carName, (double)car.DailyPrice))
            {
                _carDal.Update(car);
                return new SuccessResult($"{carName} named car is updated");
            }
            return new ErrorResult(Messages.CarNameInvalid);


        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<Car>> GetCarsByCarId(int carId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandAndColorId(int brandId, int colorId)
        {
            if (brandId != 0 && colorId != 0)
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByBrandAndColorId(brandId, colorId), Messages.ListedSuccessful);
            }
            else if (brandId != 0 && colorId == 0)
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByBrandId(brandId), Messages.ListedSuccessful);
            }
            else if (brandId == 0 && colorId != 0)
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByColorId(colorId), Messages.ListedSuccessful);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.ListedSuccessful);
            }

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
