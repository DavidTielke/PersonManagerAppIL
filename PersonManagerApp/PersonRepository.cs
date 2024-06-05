using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonRepository : IPersonRepository
{
    private readonly IFileReader _reader;
    private readonly IPersonParser _parser;

    public PersonRepository(IFileReader reader, IPersonParser parser)
    {
        _reader = reader;
        _parser = parser;
    }

    public IQueryable<Person> Query()
    {
        var csvLines = _reader.ReadAllLines("data.csv");
        var persons = csvLines.Select(line => _parser.Parse(line));
        return persons.AsQueryable();
    }
}