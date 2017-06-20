//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.EnglishGreeter.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------
namespace WindsorXmlConfigExample.Console.Dependencies
{
    public class EnglishGreeter : IGreeter
    {
        public string Greet(string name)
        {
            return $"Hello, {name}";
        }
    }
}