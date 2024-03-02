#nullable disable
namespace NorthWindOracleLibrary.Models
{
    public class Manager
    {
        public Employees Employee { get; set; }
        public List<Employees> Workers { get; set; } = [];
    }
}