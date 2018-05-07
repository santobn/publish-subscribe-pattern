using PubSub.Lib.Modules.Shared.Dtos;

namespace PubSub.Api.Publisher.Dtos
{
    public class SubscriberRegisterRequestDto : ISubscriberRegisterRequestDto
    {
        public string ListenerUrl { get; set; }
    }
}