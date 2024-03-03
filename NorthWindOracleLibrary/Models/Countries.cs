#nullable disable
namespace NorthWindOracleLibrary.Models;

public class Countries
{
    public int CountryIdentifier { get; set; }
    public string CountryName { get; set; }
    public override string ToString() => CountryName;
}
