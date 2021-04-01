using Core.DatAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal: EfEntityRepositoryBase<Payment, ReCarContext>, IPaymentDal
    {
    }
}
