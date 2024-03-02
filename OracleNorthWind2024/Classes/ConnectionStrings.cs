#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace OracleNorthWind2024.Classes;

/// <summary>
/// Available connections in appsettings.json
/// </summary>
public class ConnectionStrings
{
    public string NorthWindConnection { get; set; }
    public string SomeOtherConnection { get; set; }
}