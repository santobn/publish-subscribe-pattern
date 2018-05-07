using SimpleInjector.Packaging;
using SimpleInjector;
using PubSub.Lib.Modules.Publisher;

namespace PubSub.Modules.Publisher
{
    public class SetupIoC : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IRegisterSubscriber, RegisterSubscriber>();
            container.Register<INotifySubscriber, NotifySubscriber>();
        }
    }
}
