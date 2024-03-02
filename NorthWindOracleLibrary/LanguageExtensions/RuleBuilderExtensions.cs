using FluentValidation;

namespace NorthWindOracleLibrary.LanguageExtensions;
public static class RuleBuilderExtensions
{
    public static IRuleBuilderOptions<T, string> GeneralPhoneNumber<T>(this IRuleBuilder<T, string> builder)
        => builder
            .Matches(@"^(1-)?\d{3}-\d{4}$")
            .WithMessage("Invalid phone number");

    public static IRuleBuilderOptions<T, string> NotStartWithWhiteSpace<T>(this IRuleBuilder<T, string> builder)
        => builder
            .Must(item => item != null && !item.StartsWith(" "))
            .WithMessage("'{PropertyName}' should not start with whitespace");

    public static IRuleBuilderOptions<T, string> NotEndWithWhiteSpace<T>(this IRuleBuilder<T, string> builder)
        => builder
            .Must(item => item != null && !item.EndsWith(" "))
            .WithMessage("'{PropertyName}' should not end with whitespace");

    public static IRuleBuilderOptions<T, string> IsNotNullOrWhitespace<T>(this IRuleBuilder<T, string> builder)
        => builder
            .Must(item => item != null && !string.IsNullOrWhiteSpace(item))
            .WithMessage("'{PropertyName}' should not be empty");

    public static IRuleBuilderOptions<T, DateTime> BirthDateGreaterThan1900<T>(this IRuleBuilder<T, DateTime> builder)
        => builder
            .Must(item => item > new DateTime(1900,1,1))
            .WithMessage("'{PropertyName}' should not be empty");

}
