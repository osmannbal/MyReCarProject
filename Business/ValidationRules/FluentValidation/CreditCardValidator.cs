﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator :AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(c=> c.CVV).GreaterThan(99).WithMessage("Güvenlik Kodu tanımsız.");
        }
    }
}
