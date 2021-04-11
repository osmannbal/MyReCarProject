using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByEmail(string email);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IResult UpdateProfile(User user, string password);
    }
}
