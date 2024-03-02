using FluentValidation;
using NorthWindOracleLibrary.LanguageExtensions;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Validators;

/// <summary>
/// Validator for <see cref="Employees"/>
/// </summary>
public class EmployeesValidator : AbstractValidator<Employees>
{
    public EmployeesValidator()
    {

        RuleFor(customer => customer.FirstName)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a first name");

        RuleFor(customer => customer.LastName)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a last name");

        RuleFor(customer => customer.Title)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a title name");

        RuleFor(customer => customer.BirthDate)
            .GreaterThan(x => new DateTime(1900, 1, 1))
            .WithMessage("Birth date must be greater than 1/1/1900");
    }


}