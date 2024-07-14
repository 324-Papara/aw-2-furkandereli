using FluentValidation;
using Para.Data.Domain;

namespace Para.Bussiness.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(3, 20)
                .WithMessage("First name length must be between 3-50 characters !");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(2, 20)
                .WithMessage("Last name length must be between 2-50 characters !");

            RuleFor(x => x.IdentityNumber)
                .NotEmpty()
                .Length(11)
                .WithMessage("Identity number must be 11 characters !");

            RuleFor(x => x.Email)
                .NotEmpty()
                .Length(12, 150)
                .WithMessage("Email must be between 12-150 characters !");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty();

            RuleFor(x => x.CustomerNumber)
                .NotEmpty()
                .InclusiveBetween(1,100000)
                .WithMessage("Customer number must be between 1-100000");
        }
    }
}
