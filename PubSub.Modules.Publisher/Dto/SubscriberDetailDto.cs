using PubSub.Lib.Modules.Publisher.Dto;

namespace PubSub.Modules.Publisher.Dto
{
    public class SubscriberDetailDto : ISubscriberDetailDto
    {
        public string ListenerUrl { get; set; }
    }
}
