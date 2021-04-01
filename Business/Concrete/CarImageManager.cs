using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        //[SecuredOperation("Add")]
        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImagesLimitExceded(carImage.CarId));
            if (result!=null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.AddAsync(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImagesAdded);
        }

        [SecuredOperation("Delete")]
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),(Messages.CarImagesListed));
        }

        public IDataResult<CarImage> GetById(int carId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c=> c.CarId == carId));
        }

        [SecuredOperation("Update")]
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImagesUpdated);
        }

        private IResult CheckIfCarImagesLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c=> c.CarId == carId);
            if (result.Count>5)
            {
                return new ErrorResult(Messages.CarImagesLimitedExceded);
            }
            return new SuccessResult();
        }

        private List<CarImage> CheckIfCarImageNull(int carId)
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\wwwroot\Images\CarImages\default.jpg");
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (!result.Any())
            {
                return new List<CarImage> { new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = path }};
            }
            return _carImageDal.GetAll(c => c.CarId == carId);
        }

        public IDataResult<List<CarImage>> GetByImages(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(carId));
        }
    }
}
