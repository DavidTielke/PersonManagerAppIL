using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

internal interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}