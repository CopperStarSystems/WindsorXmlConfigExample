//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.GreeterConsumer.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

using WindsorXmlConfigExample.Console.Dependencies;

namespace WindsorXmlConfigExample.Console
{
    public class GreeterConsumer : IGreeterConsumer
    {
        readonly IGreeter greeter;

        public GreeterConsumer(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public void GreetToConsole(string name)
        {
            System.Console.WriteLine($"{greeter.Greet(name)}!");
        }
    }
}