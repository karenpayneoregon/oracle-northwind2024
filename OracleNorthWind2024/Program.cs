using OracleNorthWind2024.Classes;

namespace OracleNorthWind2024;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorPages();

        builder.LoggingSetup();

        builder.DatabaseSetup();

        builder.Services.RegisterServices();

        builder.Services.AddExceptionHandler<DefaultExceptionHandle>();
        builder.Services.AddProblemDetails();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseHsts();
        }

        app.UseExceptionHandler();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthorization();
        app.MapRazorPages();
        app.Run();
    }
}
