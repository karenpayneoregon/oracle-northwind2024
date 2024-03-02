using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;


namespace OracleNorthWind2024.Pages;

public class ProductsPageModel : PageModel
{
    private readonly IOperations<Products> _productsService;

    [BindProperty]
    public List<Products> Products { get; set; }
    public ProductsPageModel(IOperations<Products> customersService)
    {
        _productsService = customersService;
        Products = _productsService.GetAll();
    }

    public void OnGet()
    {
    }
}