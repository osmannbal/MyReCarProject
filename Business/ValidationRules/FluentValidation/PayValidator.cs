using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PayValidator : AbstractValidator<Payment>
    {
        public PayValidator()
        {
            RuleFor(p => p.CVV).GreaterThan(99).WithMessage("Güvenlik Kodu tanımsız.");
           
        }
    }
}
