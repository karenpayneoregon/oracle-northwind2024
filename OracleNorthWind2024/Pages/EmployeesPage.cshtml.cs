using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;
using NorthWindOracleLibrary.Services;
using Serilog;
#pragma warning disable CA1866
#pragma warning disable CA1866

namespace OracleNorthWind2024.Pages;

public class EmployeesPageModel : PageModel
{
    private readonly Context _context;
    public IEmployeesService EmployeesService { get; }
    [BindProperty]
    public IList<Employees> Employees { get; set; }

    public EmployeesPageModel(Context context)
    {
        _context = context;
        EmployeesService = new EmployeesService(_context);
        Employees = EmployeesService.GetEmployees();
        Employees employee = EmployeesService.GetById(1)!;
        if (employee is not null)
        {

            employee.FirstName = employee.FirstName.EndsWith("1") ? "Nancy" : "Nancy1";

            var (result, exception) = EmployeesService.UpdateFirstNameOnly(employee);
            if (result)
            {
                Log.Information("Update successful");
            }
            else
            {
                Log.Error(exception, "Update failed");
            }
        }
    }
    public void OnGet() { }
}