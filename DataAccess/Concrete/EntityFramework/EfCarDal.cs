using Core.DatAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join l in context.Colors
                             on c.ColorId equals l.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = l.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 FindexPoint = c.FindexPoint,
                                 ImagePath = context.CarImages.Where(x => x.CarId == c.CarId).FirstOrDefault().ImagePath
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();



            }
        }

        //public CarDetailDto GetByCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter)
        //{
        //    using (ReCarContext context = new ReCarContext())
        //    {
        //        var result = from c in context.Cars
        //                     join b in context.Brands
        //                     on c.BrandId equals b.BrandId
        //                     join l in context.Colors
        //                     on c.ColorId equals l.ColorId
        //                     //join x in context.CarImages
        //                     //on c.CarId equals x.CarId
        //                     select new CarDetailDto
        //                     {
        //                         CarId = c.CarId,
        //                         CarName = c.CarName,
        //                         BrandName = b.BrandName,
        //                         ColorName = l.ColorName,
        //                         ModelYear = c.ModelYear,
        //                         DailyPrice = c.DailyPrice,
        //                         Description = c.Description
        //                         //ImagePath = x.ImagePath
        //                     };

        //        return result.FirstOrDefault(filter);



        //    }
        //}

        public List<CarDetailDto> GetCarsByFilter(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join l in context.Colors
                             on c.ColorId equals l.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 ColorId = l.ColorId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = l.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = context.CarImages.Where(x => x.CarId == c.CarId).SingleOrDefault().ImagePath
                             };
                return result.Where(filter).ToList();
            }
        }
    }
}
