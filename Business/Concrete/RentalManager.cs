using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {

            IResult result = BusinessRules.Run(CheckAvailability(rental.CarId, rental.RentDate));
            if (result != null)
            {
                return result;

            }
            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.ListedRentals);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.ListedRentals);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedRental);
        }

        public IDataResult<List<Rental>> GetRentalByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<Rental> GetByCarId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == id));
        }

        private IResult CheckAvailability(int carId, DateTime newRentDate)
        {
            var result = _rentalDal.GetAll(c => c.CarId == carId);
            if (result != null)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].ReturnDate > newRentDate)
                    {
                        return new ErrorResult(Messages.CarIsNotAvailable);
                    }

                }

            }
            return new SuccessResult();

        }


    }
}
