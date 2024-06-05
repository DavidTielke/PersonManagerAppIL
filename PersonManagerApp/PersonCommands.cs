namespace PersonManagerApp;

internal class PersonCommands : IPersonCommands
{
    private IPersonManager _manager;

    public PersonCommands(IPersonManager manager)
    {
        _manager = manager;
    }


    public void DisplayAllAdults()
    {
        var adults = _manager.GetAllAdults().ToList();
        Console.WriteLine($"### ADULTS ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void DisplayAllChildren()
    {
        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### CHILDREN ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}