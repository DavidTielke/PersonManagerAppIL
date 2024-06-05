using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

internal interface IPersonParser
{
    Person Parse(string csvDataLine);
}