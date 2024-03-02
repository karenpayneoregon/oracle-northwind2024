using FluentValidation;
using NorthWindOracleLibrary.LanguageExtensions;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Validators;

/// <summary>
/// Validator for <see cref="Shippers"/>
/// </summary>
public class ShippersValidator : AbstractValidator<Shippers>
{
    public ShippersValidator()
    {
        RuleFor(product => product.CompanyName)
            .NotEmpty()
            .MinimumLength(3)
            .WithMessage("Enter a product name");

        RuleFor(customer => customer.Phone)
            .GeneralPhoneNumber();
    }
}