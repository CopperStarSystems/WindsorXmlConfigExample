//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.Bootstrapper.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace WindsorXmlConfigExample.Console.Bootstrap
{
    public static class Bootstrapper
    {
        public static IWindsorContainer BootstrapContainer()
        {
            var container = new WindsorContainer();
            // Install types registered in App.Config
            container.Install(Configuration.FromAppConfig());

            // Manually register GreeterConsumer
            container.Register(Component.For<IGreeterConsumer>()
                                        .ImplementedBy<GreeterConsumer>()
                                        .LifestyleTransient());



            return container;
        }
    }
}