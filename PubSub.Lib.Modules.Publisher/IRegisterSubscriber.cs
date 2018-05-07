using PubSub.Lib.Modules.Publisher.Dto;

namespace PubSub.Lib.Modules.Publisher
{
    public interface IRegisterSubscriber
    {
        void Register(ISubscriberDetailDto subscriberDetailDto);
    }
}
