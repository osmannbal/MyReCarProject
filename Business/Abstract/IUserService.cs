using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
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
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
