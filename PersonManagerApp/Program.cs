using System.Security.Principal;
using PersonManagerApp.DataClasses;

namespace PersonManagerApp
{
    public class Program
    {
        private static PersonCommands _commands;

        static void Main(string[] args)
        {
            var reader = new FileReader();
            var parser = new PersonParser();
            var repository = new PersonRepository(reader, parser);
            var manager = new PersonManager(repository);
            _commands = new PersonCommands(manager);

            _commands.DisplayAllAdults();
            _commands.DisplayAllChildren();
        }
    }
}
