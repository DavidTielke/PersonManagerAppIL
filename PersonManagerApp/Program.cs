using System.Security.Principal;
using Microsoft.Extensions.DependencyInjection;
using PersonManagerApp.DataClasses;

namespace PersonManagerApp
{
    public class Program
    {
        private static IPersonCommands _commands;

        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IPersonCommands, PersonCommands>();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();

            var serviceProvider = collection.BuildServiceProvider();

            _commands = serviceProvider.GetRequiredService<IPersonCommands>();

            _commands.DisplayAllAdults();
            _commands.DisplayAllChildren();
        }
    }
}
