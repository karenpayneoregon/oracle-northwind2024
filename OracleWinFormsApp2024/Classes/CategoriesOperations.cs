using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Models;

namespace OracleWinFormsApp2024.Classes;
internal class CategoriesOperations
{
    public static List<Categories> GetAll()
    {
        var files = FileOperations.GetImages();
        using var context = new Context();
        var categories = context.Categories.ToList();

        for (int index = 0; index < categories.Count; index++)
        {
            byte[] bytes = File.ReadAllBytes(files[index]);
            categories[index].Picture = bytes.BytesToImage();
        }

        return categories;
    }
}
