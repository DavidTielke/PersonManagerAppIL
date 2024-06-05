namespace PersonManagerApp;

internal interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}