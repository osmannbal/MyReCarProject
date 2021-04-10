using Core.DatAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCarContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCarContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public void UpdateFor(UserForUpdateDto userForUpdateDto)
        {
            using (var context = new ReCarContext())
            {
                User user = new User()
                {
                    Id = userForUpdateDto.UserId,
                    FirstName = userForUpdateDto.FirstName,
                    LastName = userForUpdateDto.LastName,
                    Email = userForUpdateDto.Email
                };

                //Customer customer = new Customer()
                //{
                //    CompanyName = userForUpdateDto.CompanyName,
                //    CustomerId = userForUpdateDto.CustomerId,
                //    UserId = userForUpdateDto.UserId
                //};
                
                var updatedEntity = context.Entry(user);
                //var updatedEntity1 = context.Entry(customer);
                updatedEntity.State = EntityState.Modified;
                //updatedEntity1.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
