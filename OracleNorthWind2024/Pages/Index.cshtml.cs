using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.LanguageExtensions;
using NorthWindOracleLibrary.Models;
using NorthWindOracleLibrary.Validators;
using Serilog;

namespace OracleNorthWind2024.Pages;
public class IndexModel : PageModel
{
    private readonly Context _context;

    public IndexModel(Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Customers Customers { get; set; } = default!;

    public void OnGet()
    {
        // start with a valid record
        Customers = new()
        {
            ContactTitle = "Owner",
            CompanyName = "ABC",
            ContactName = "Karen Payne",
            Phone = "999-1234"
        };



    }

    public PageResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        else
        {
            // insert new record
            return Page();
        }
    }

    private static void TestCustomersValidator()
    {
        Customers customers = new()
        {
            ContactTitle = "Owner1", CompanyName = "", ContactName = "", Phone = "999-1234"
        };

        CustomersValidator validator = new();
        ValidationResult result = validator.Validate(customers);

        if (!result.IsValid)
        {
            result.ShowErrorMessages();
        }
        else
        {
            Log.Information("Is valid {P1}", result.IsValid);
        }
    }
}
