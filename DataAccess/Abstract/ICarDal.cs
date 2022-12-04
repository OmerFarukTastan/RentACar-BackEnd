using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAllCars();

        void Add(Car car);

        void Delete(int id);

        void Update(Car car);

        List<Car> GetById(int Id);
        
    }
}
