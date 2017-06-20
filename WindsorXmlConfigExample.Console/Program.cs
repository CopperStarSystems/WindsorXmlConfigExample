//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.Program.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

using Castle.Windsor;
using WindsorXmlConfigExample.Console.Bootstrap;

namespace WindsorXmlConfigExample.Console
{
    class Program
    {
        static IWindsorContainer container;
        static string userName;

        static void BootstrapContainer()
        {
            container = Bootstrapper.BootstrapContainer();
        }

        static void Main(string[] args)
        {
            BootstrapContainer();

            System.Console.WriteLine("Please enter your name.");
            userName = System.Console.ReadLine();

            var consumer = container.Resolve<IGreeterConsumer>();
            consumer.GreetToConsole(userName);
            
            System.Console.ReadLine();
        }
    }
}