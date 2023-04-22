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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                    join brand in context.Brands
                        on car.BrandId equals brand.BrandId
                    join rent in context.Rentals
                        on car.Id equals rent.CarId
                    join color in context.Colors
                        on car.ColorId equals color.ColorId
                    join cust in context.CustomersRecap
                        on rent.CustomerId equals cust.UserId
                    join user in context.Users
                        on cust.UserId equals user.Id


                    select new RentalDetailDto
                    {
                        RentalId = rent.Id,
                        BrandId = brand.BrandId,
                        CarId = car.Id,
                        ColorId = color.ColorId,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        ModelName = car.Description,
                        UserName = user.FirstName + " " + user.LastName,
                        RentDate = rent.RentDate,
                        ReturnDate = rent.ReturnDate

                    };
                return result.ToList();
            }
        }
    }
}
