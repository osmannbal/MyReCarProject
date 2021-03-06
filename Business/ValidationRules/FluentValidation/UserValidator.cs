﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
       
        public UserValidator()
        {   
            
            
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Kullanıcının adı boş bırakılamaz!");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Kullancının soyadı boş bırakılamaz!");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Mail adresi boş bırakılamaz!");
       
            
        }
    }
}
