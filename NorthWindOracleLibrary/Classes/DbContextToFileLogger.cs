using System.Diagnostics;
using static System.DateTime;
using File = System.IO.File;

// ReSharper disable BitwiseOperatorOnEnumWithoutFlags
// ReSharper disable EmptyEmbeddedStatement

#pragma warning disable IDE0063

namespace NorthWindOracleLibrary.Classes;

/// <summary>
/// For logging messages from DbContext.
/// 
/// DO NOT use in production, only development environment
/// 
/// Totally void of exception handling as this is for use by a developer on their machine
/// were they need the proper permissions to create and write to files.
/// 
/// </summary>
public class DbContextToFileLogger
{

    /// <summary>
    /// Log file name
    /// </summary>
    private readonly string _fileName = 
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
            "LogFiles", $"{Now.Year}-{Now.Month:D2}-{Now.Day:d2}", 
            "EF_Log.txt");

    /// <summary>
    /// Use to override log file name and path, file must exist
    /// </summary>
    /// <param name="fileName"></param>
    public DbContextToFileLogger(string fileName)
    {
        _fileName = fileName;
    }

    /// <summary>
    /// Setup to use default file name for logging
    /// </summary>
    public DbContextToFileLogger()
    {
        using (var file = File.Open(_fileName, FileMode.OpenOrCreate | FileMode.Append)) ;
    }

    /// <summary>
    /// append message to the existing stream
    /// </summary>
    /// <param name="message"></param>
    [DebuggerStepThrough]
    public void Log(string message)
    {

        if (!File.Exists(_fileName))
        {
            File.CreateText(_fileName).Close();
        }

        StreamWriter streamWriter = new(_fileName, true);

        streamWriter.WriteLine(message);

        streamWriter.WriteLine(new string('-', 40));

        streamWriter.Flush();
        streamWriter.Close();
    }
}