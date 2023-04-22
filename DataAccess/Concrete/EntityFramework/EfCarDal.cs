using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext> , ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {

                                 CarId = c.Id,
                                 BrandId = b.BrandId,
                                 ColorId = co.ColorId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ModelName = c.Description,
                                 Description = c.Description,
                                 ImagePath = (from img in context.CarImages
                                              where img.CarId == c.Id
                                              select img.ImagePath).FirstOrDefault()
                             };
                return filter == null ? result.ToList()
                                      : result.Where(filter).ToList();
            }
        }

        public List<CarDetailDto> GetCarsByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandAndColorId(int brandId, int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             where c.BrandId == brandId && c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }
    }

    


    


    






    //public void Add(Car item)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        var addedEntity = context.Entry(item);
    //        addedEntity.State = EntityState.Added;
    //        context.SaveChanges();
    //    }
    //}

    //public void Delete(int id)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        var deletedColor = context.Entry(id);
    //        deletedColor.State = EntityState.Deleted;
    //        context.SaveChanges();
    //    }
    //}

    //public void DeleteByEntity(Car item)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        var deletedEntity = context.Entry(item);
    //        deletedEntity.State = EntityState.Deleted;
    //        context.SaveChanges();
    //    }
    //}

    //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        return filter == null ?
    //            context.Set<Car>().ToList() :
    //            context.Set<Car>().Where(filter).ToList();
    //    }
    //}

    //public List<Car> GetAllCars()
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        return context.Set<Car>().ToList();
    //    }
    //}

    //public List<Car> GetById(int Id)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        return context.Set<Car>().ToList();
    //    }
    //}

    //public void Update(Car car)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        var updatedEntity = context.Entry(car);
    //        updatedEntity.State = EntityState.Modified;
    //        context.SaveChanges();
    //    }
    //}

    //public Car Get(Expression<Func<Car, bool>> filter)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        return context.Set<Car>().SingleOrDefault(filter);
    //    }
    //}

    //public List<Car> GetAllCars(Func<object, bool> value)
    //{
    //    using (RentACarContext context = new RentACarContext())
    //    {
    //        return context.Set<Car>().ToList();
    //    }
    //}
}

