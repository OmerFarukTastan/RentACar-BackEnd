using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;

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
            _carDal.Add(car);
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
    }


}
