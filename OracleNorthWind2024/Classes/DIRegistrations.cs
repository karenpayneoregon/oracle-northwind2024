using FluentValidation;
using FluentValidation.AspNetCore;
using LazyProxy.ServiceProvider;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;
using NorthWindOracleLibrary.Services;
using NorthWindOracleLibrary.Validators;

namespace OracleNorthWind2024.Classes;

public static class DIRegistrations
{
    /// <summary>
    /// Register all services for the application
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/></param>
    /// <returns>Collection of services</returns>
    /// <remarks>
    /// The objective is to keep Program.cs clean and if using this style, do this for all projects.
    /// </remarks>
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {

        // Bad per-say as the interface is only for one type
        //services.AddLazySingleton<IEmployeesService, EmployeesService>();

        // Good universal 
        services.AddScoped(typeof(IOperations<Products>), typeof(ProductsService));
        services.AddScoped(typeof(IOperations<Customers>), typeof(CustomersService));
        services.AddScoped(typeof(IOperations<ContactType>), typeof(ContactTypeService));
        services.AddScoped(typeof(IEmployeesService), typeof(EmployeesService));

        // FluentValidation validators
        services.AddScoped<IValidator<Customers>, CustomersValidator>();
        services.AddScoped<IValidator<Products>, ProductsValidator>();
        services.AddScoped<IValidator<Shippers>, ShippersValidator>();
        services.AddScoped<IValidator<Employees>, EmployeesValidator>();
        services.AddScoped<IValidator<ContactType>, ContactTypeValidator>();

        // https://github.com/FluentValidation/FluentValidation.AspNetCore?tab=readme-ov-file#automatic-validation
        services.AddFluentValidationAutoValidation();

        return services;

    }
}


