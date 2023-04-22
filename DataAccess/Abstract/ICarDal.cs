using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DateAccess;
using Entities.Concrete;
using DataAccess.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
        List<CarDetailDto> GetCarDetailsByBrandAndColorId(int brandId, int colorId);
        List<CarDetailDto> GetCarsByBrandId(int brandId);
        List<CarDetailDto> GetCarsByColorId(int colorId);
    } 
}
