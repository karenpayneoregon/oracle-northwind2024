using FluentValidation;
using NorthWindOracleLibrary.Classes;
using NorthWindOracleLibrary.LanguageExtensions;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Validators;

/// <summary>
/// Validator for <see cref="Customers"/>
/// </summary>
public class CustomersValidator : AbstractValidator<Customers>
{
    public CustomersValidator()
    {

        RuleFor(customer => customer.CompanyName)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a company name");

        /*
         * This is needed because of not properly normalizing Customer model
         */
        var contactTitles = ReferenceLists
            .CustomerTitles()
            .Select(x => x.ContactTitle)
            .ToList();

        RuleFor(customer => customer.ContactTitle)
            .IsNotNullOrWhitespace()
            .Must((customer, _) => contactTitles.Contains(customer.ContactTitle))
            .WithMessage("Invalid contact title");

        RuleFor(customer => customer.ContactName)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a contact name");

        RuleFor(customer => customer.Phone)
            .GeneralPhoneNumber();
    }
}