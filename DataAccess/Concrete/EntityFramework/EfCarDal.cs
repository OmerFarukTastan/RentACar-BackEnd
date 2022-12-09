using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car item)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedEntity = context.Entry(item);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedColor = context.Entry(id);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeleteByEntity(Car item)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedEntity = context.Entry(item);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetAllCars()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().ToList();
            }
        }

        public List<Car> GetById(int Id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().ToList();
            }
        }

        public void Update(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAllCars(Func<object, bool> value)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().ToList();
            }
        }
    }
}
