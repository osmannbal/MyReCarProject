using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    { 
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByImages(int carId);
        IDataResult<CarImage> GetById(int carId);
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}
