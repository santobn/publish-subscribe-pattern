using SimpleInjector.Packaging;
using SimpleInjector;
using PubSub.Lib.Modules.Processor;

namespace PubSub.Modules.Processor
{
    public class SetupIoC : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IMessageProcessor, MessageProcessor>();
        }
    }
}
