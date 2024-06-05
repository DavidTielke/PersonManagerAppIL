namespace PersonManagerApp;

class FileReader : IFileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        var readLines = File.ReadAllLines(path);
        return readLines;
    }
}