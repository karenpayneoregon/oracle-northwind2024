using NorthWindOracleLibrary.Models;
namespace OracleWinFormsApp2024.Classes;
public class FileOperations
{
    /// <summary>
    /// Get names of all images for <see cref="Categories"/>
    /// </summary>
    /// <returns>List of file names with full path</returns>
    public static List<string> GetImages()
        => Directory.GetFiles(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NorthImage"))
            .ToList();
}
