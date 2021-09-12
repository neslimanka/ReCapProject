using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ConsumerValidator : AbstractValidator<Consumer>
    {
        public ConsumerValidator()
        {
            RuleFor(u => u.Email).NotNull().NotEmpty();
            RuleFor(u => u.FirstName).NotNull().NotEmpty();
            RuleFor(u => u.LastName).NotNull().NotEmpty();
        }
    }
}
