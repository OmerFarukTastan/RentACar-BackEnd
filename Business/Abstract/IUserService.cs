using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IResult Update(User user);
        IResult Delete(User user);
        IResult UpdateByDto(UserDto userDto);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
