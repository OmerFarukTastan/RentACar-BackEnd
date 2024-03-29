﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        
        IDataResult<List<Rental>> GetRentalByCarId(int id);

        IDataResult<Rental> GetByCarId(int id);
    }
}
