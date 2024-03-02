using System.Text;
using FluentValidation.Results;
using Serilog;

namespace NorthWindOracleLibrary.LanguageExtensions;

/// <summary>
/// Helper methods for development environment only
/// </summary>
public static class FluentValidationLocalExtensions
{
    public static string PresentErrorMessage(this ValidationResult sender)
    {
        StringBuilder builder = new();

        sender.Errors.Select(validationFailure => validationFailure.ErrorMessage)
            .ToList()
            .ForEach(x => builder.AppendLine(x));
        

        return builder.Length == 0 ?
            "Valid" :
            builder.ToString();

    }
    public static string PresentErrorMessageWihProperties(this ValidationResult sender)
    {
        StringBuilder builder = new();

        foreach (var error in sender.Errors)
        {
            builder.AppendLine($"{error.PropertyName,-30}{error.ErrorMessage}");
        }

        return builder.Length == 0 ?
            "Valid" :
            builder.ToString();

    }
    /// <summary>
    /// Uses SeriLog to log to disk and console all errors
    /// </summary>
    /// <param name="sender"></param>
    public static void ShowErrorMessages(this ValidationResult sender)
    {
        Log.Information($"\n{PresentErrorMessageWihProperties(sender)}");
    }

}
