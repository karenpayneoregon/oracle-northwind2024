using LazyProxy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;
using OracleNorthWind2024.Interfaces;
using Serilog;

namespace OracleNorthWind2024.Pages
{
    public class CustomersPageModel : PageModel
    {
        
        private readonly IOperations<Customers> _customersService;

        public CustomersPageModel(IOperations<Customers> service)
        {

            _customersService = service;
            var list = _customersService.GetAll();
            Log.Information("Customer count {P1}", list.Count());
        }

        public void OnGet()
        {
        }
    }
}
