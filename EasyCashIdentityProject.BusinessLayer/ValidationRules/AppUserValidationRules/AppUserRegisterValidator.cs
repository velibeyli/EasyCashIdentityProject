using EasyCashIdentityProject.DtoLayer.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name field can not be empty!")
                .NotNull().WithMessage("Name field can not be null!")
                .MaximumLength(30).WithMessage("Name can not be more than 30 character!")
                .MinimumLength(3).WithMessage("Name should be at least 3 character");
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname field can not be empty!")
                .NotNull().WithMessage("Surname field can not be null!");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email field can not be empty!")
                .NotNull().WithMessage("Email field can not be null!")
                .EmailAddress().WithMessage("Please enter true email address!");
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username field can not be empty!")
                .NotNull().WithMessage("Username field can not be null!");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password field can not be empty!")
                .NotNull().WithMessage("Password field can not be null!");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm password field can not be empty!")
                .NotNull().WithMessage("Confirm password field can not be null!")
                .Equal(y => y.Password).WithMessage("password and confirm password does not matches!");
        }
    }
}
