using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        ICustomerService _customerService;
        public UserManager(IUserDal userDal, ICustomerService customerService)
        {
            _userDal = userDal;
            _customerService = customerService;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            Customer customer = new Customer()
            {
                UserId = user.Id,
                CompanyName = user.LastName
            };
            _customerService.Add(customer);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
            
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public User GetById(int userId)
        {
            return _userDal.Get(u=> u.Id == userId);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
            
        }

        public IResult Update(UserForUpdateDto userForUpdateDto)
        {
            _userDal.UpdateFor(userForUpdateDto);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
