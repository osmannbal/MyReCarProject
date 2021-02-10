using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        new List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        List<CarDetailDto> GetCarDetailDtos();
    }
}
