using Core.DatAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDtos()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.CustomerId equals u.Id
                             select new CustomerDetailDto { CustomerId = c.CustomerId, CompanyName = c.CompanyName, FirstName = u.FirstName, LastName = u.LastName };
                return result.ToList();
            }
        }
    }
}
