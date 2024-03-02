using Microsoft.EntityFrameworkCore;
using NorthWindOracleLibrary.Classes;
using NorthWindOracleLibrary.Data;
using Serilog;
using SeriLogThemesLibrary;
using static System.DateTime;

namespace OracleNorthWind2024.Classes;

public static class AppConfiguration
{
    /// <summary>
    /// Setup SeriLog
    /// -  development, write to file and console
    /// -  other environments write to file
    /// </summary>
    public static void LoggingSetup(this WebApplicationBuilder builder)
    {
        if (builder.Environment.IsDevelopment())
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console(theme: SeriLogCustomThemes.Theme1())
                .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFiles", $"{Now.Year}-{Now.Month:d2}-{Now.Day:d2}", "Log.txt"),
                    rollingInterval: RollingInterval.Infinite,
                    outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
                .CreateLogger();
        }
        else
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFiles", $"{Now.Year}-{Now.Month:d2}-{Now.Day:d2}", "Log.txt"),
                    rollingInterval: RollingInterval.Infinite,
                    outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
                .CreateLogger();
        }

    }
    
    /// <summary>
    /// Setup database connection base on environment
    /// </summary>
    /// <remarks>
    /// Shows two different ways to get the connection string from appsettings.json. How it's done
    /// in production is recommended.
    /// </remarks>
    public static void DatabaseSetup(this WebApplicationBuilder builder)
    {
 
        if (builder.Environment.IsDevelopment())
        {
            builder.Services.AddDbContext<Context>(options =>
                options.UseOracle(builder.Configuration.GetConnectionString(nameof(ConnectionStrings.NorthWindConnection)))
                    .EnableSensitiveDataLogging()
                    .LogTo(new DbContextToFileLogger().Log, new[]
                        {
                            DbLoggerCategory.Database.Command.Name
                        },
                        LogLevel.Information));
        }
        else
        {
            builder.Services.AddDbContext<Context>(options =>
                options.UseOracle(builder.Configuration.GetConnectionString(nameof(ConnectionStrings.NorthWindConnection)))
                    .LogTo(new DbContextToFileLogger().Log, new[]
                        {
                            DbLoggerCategory.Database.Command.Name
                        },
                        LogLevel.Information));
        }
    }
}
