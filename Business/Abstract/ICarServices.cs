using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;

namespace Business.Abstract
{
    public interface ICarServices
    {
        List<Car> GetAll();

        void Add(Car car);

        void Delete(int id);

        void Update(Car car);

        List<Car> GetById(int Id);
    }
}
