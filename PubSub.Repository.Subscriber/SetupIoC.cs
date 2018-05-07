using SimpleInjector.Packaging;
using SimpleInjector;
using PubSub.Lib.Repository.Subscriber;

namespace PubSub.Repository.Subscriber
{
    public class SetupIoC : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ISubscriberRepository, SubscriberRepository>(Lifestyle.Singleton);
        }
    }
}
