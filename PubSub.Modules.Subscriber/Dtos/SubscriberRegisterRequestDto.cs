using PubSub.Lib.Modules.Shared.Dtos;

namespace PubSub.Modules.Subscriber.Dtos
{
    public class SubscriberRegisterRequestDto : ISubscriberRegisterRequestDto
    {
        public string ListenerUrl { get; set; }
    }
}
