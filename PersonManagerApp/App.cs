namespace PersonManagerApp;

class App
{
    private IPersonCommands _commands;

    public App(IPersonCommands commands)
    {
        _commands = commands;
    }

    public void Run()
    {
        _commands.DisplayAllAdults();
        _commands.DisplayAllChildren();
    }
}