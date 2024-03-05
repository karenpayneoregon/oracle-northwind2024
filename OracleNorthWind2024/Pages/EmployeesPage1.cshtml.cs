using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;
using NorthWindOracleLibrary.Services;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace OracleNorthWind2024.Pages
{

    public class EmployeesPage1Model(Context context) : PageModel
    {
        [BindProperty]
        public IList<Employees> Employees { get; set; }
        public void OnGet([FromServices] IEmployeesService service)
        {
            Employees = service.GetEmployees();
        }               
    }


}
