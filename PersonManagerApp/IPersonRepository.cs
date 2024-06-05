using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

internal interface IPersonRepository
{
    IQueryable<Person> Query();
}