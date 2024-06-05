using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonParser : IPersonParser
{
    public Person Parse(string csvDataLine)
    {
        var parts = csvDataLine.Split(',');
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
        return person;
    }
}

// Rule 1: All Classes with more than 220 (2) LOC OR more than 8 (2) Methods
// Rule 2: All Methods with more than 20 (2) LOC OR more Cyclomatic Complexity than 7 (2)