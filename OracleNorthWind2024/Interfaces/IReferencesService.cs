using Microsoft.AspNetCore.Mvc.Rendering;

namespace OracleNorthWind2024.Interfaces;

#pragma warning disable CS8618
/// <summary>
/// For HTML select elements
/// </summary>
public interface IReferencesService
{
    public List<SelectListItem> Categories { get; set; }
}