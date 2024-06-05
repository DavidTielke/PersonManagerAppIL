using System.Security.Principal;
using Microsoft.Extensions.DependencyInjection;
using PersonManagerApp.DataClasses;

namespace PersonManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceProviderFactory().Create();
            serviceProvider.GetRequiredService<App>().Run();
        }
    }
}
