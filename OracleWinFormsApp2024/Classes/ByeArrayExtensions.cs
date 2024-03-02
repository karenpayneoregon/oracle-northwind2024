namespace OracleWinFormsApp2024.Classes;
public static class ByeArrayExtensions
{
    /// <summary>
    /// Convert byte array suitable to<seealso cref="Image"/>  display image in a <see cref="DataGridView"/>
    /// </summary>
    /// <param name="bytes">byte array read from file</param>
    public static Image BytesToImage(this byte[] bytes)
    {
        var imageData = bytes;
        using var ms = new MemoryStream(imageData, 0, imageData.Length);
        ms.Write(imageData, 0, imageData.Length);
        return Image.FromStream(ms, true); 
    }
}
