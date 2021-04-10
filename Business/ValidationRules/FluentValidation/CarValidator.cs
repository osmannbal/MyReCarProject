using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Araba adı boş olamaz!");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araba adı minimum 2 karakterli olmalı!");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Günlük fiyat boş olamaz!");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Günlük fiyat 0'dan büyük olmalıdır!");
            RuleFor(c => c.FindexPoint).InclusiveBetween(0, 1900).WithMessage("Findeks puan 0-1900 aralığında olmalıdır.");
        }
    }
}
