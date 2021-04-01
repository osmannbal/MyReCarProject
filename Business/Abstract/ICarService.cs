using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int carId);
        IDataResult<List<CarDetailDto>> GetAllCarDetailDtos();
        IDataResult<List<CarDetailDto>> GetByCarDetailDtos(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult Transactional(Car car);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetBrandDetailDtos(int brandId);
        IDataResult<List<CarDetailDto>> GetColorDetailDtos(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsByFilter(int brandId, int colorId);
    }
}
