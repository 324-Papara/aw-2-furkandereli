using FluentValidation;
using Para.Data.Domain;

namespace Para.Bussiness.Validations
{
    public class CustomerPhoneValidator : AbstractValidator<CustomerPhone>
    {
        public CustomerPhoneValidator()
        {
            RuleFor(x => x.CountyCode)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Country Code must be minimum 3 characters !");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .Length(10)
                .WithMessage("Phone number must be 10 characters !");
        }
    }
}
