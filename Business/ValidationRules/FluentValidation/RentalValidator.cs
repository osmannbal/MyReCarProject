using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Kiralama işlemi için araba ID'si gereklidir.");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Kiralama işlemi için müşteri ID'si gerekidir.");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş bırakılamaz!");
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Teslim tarihi boş ise kiralama işlemi yapılamaz.");
           
        }
    }
}
