using SimpleInjector.Packaging;
using SimpleInjector;
using PubSub.Lib.Modules.Subscriber;

namespace PubSub.Modules.Subscriber
{
    public class SetupIoC : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IDisplayMessage, DisplayMessage>();
        }
    }
}
