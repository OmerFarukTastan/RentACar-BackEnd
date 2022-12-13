using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarServices
    {
        List<Car> GetAll();

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

        List<Car> GetById(int Id);

        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailDto> GetCarDetails();
    }
}
