using Microsoft.Extensions.DependencyInjection;

namespace PersonManagerApp;

public class ServiceProviderFactory
{
    public IServiceProvider Create()
    {
        var collection = new ServiceCollection();
        collection.AddTransient<App>();
        collection.AddTransient<IPersonCommands, PersonCommands>();
        collection.AddTransient<IPersonManager, PersonManager>();
        collection.AddTransient<IPersonRepository, PersonRepository>();
        collection.AddTransient<IPersonParser, PersonParser>();
        collection.AddTransient<IFileReader, FileReader>();

        var serviceProvider = collection.BuildServiceProvider();
        return serviceProvider;
    }
}