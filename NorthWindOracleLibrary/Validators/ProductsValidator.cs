using FluentValidation;
using NorthWindOracleLibrary.LanguageExtensions;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Validators;
/// <summary>
/// Validator for <see cref="Products"/>
/// </summary>
public class ProductsValidator : AbstractValidator<Products>
{
    public ProductsValidator()
    {
        RuleFor(product => product.ProductName)
            .IsNotNullOrWhitespace()
            .WithMessage("Enter a product name");


    }
}
