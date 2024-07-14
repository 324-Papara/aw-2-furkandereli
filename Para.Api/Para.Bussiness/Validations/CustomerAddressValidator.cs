using FluentValidation;
using Para.Data.Domain;

namespace Para.Bussiness.Validations
{
    public class CustomerAddressValidator : AbstractValidator<CustomerAddress>
    {
        public CustomerAddressValidator()
        {
            RuleFor(x => x.Country)
                .NotEmpty()
                .Length(1, 25)
                .WithMessage("Country must be 1-25 characters !");

            RuleFor(x => x.City)
                .NotEmpty()
                .Length(1, 190)
                .WithMessage("City must be 1-190 characters !");

            RuleFor(x => x.AddressLine)
                .NotEmpty()
                .MaximumLength(200)
                .WithMessage("Adressline maximum length 200 characters !");

            RuleFor(x => x.ZipCode)
                .NotEmpty()
                .Length(11)
                .WithMessage("ZipCode must be 11 characters !");
        }
    }
}
