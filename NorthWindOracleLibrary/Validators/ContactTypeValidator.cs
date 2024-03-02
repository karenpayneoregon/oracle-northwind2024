using FluentValidation;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Validators;

/// <summary>
/// Validator for <see cref="ContactType"/>
/// </summary>
public class ContactTypeValidator : AbstractValidator<ContactType>
{
    public ContactTypeValidator()
    {
        RuleFor(product => product.ContactTitle)
            .NotEmpty()
            .MinimumLength(3)
            .WithMessage("Enter a contact title");
    }
}