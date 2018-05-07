using PubSub.Lib.Modules.Publisher.Dto;

namespace PubSub.Modules.Publisher.Dto
{
    public class NotifyMessageDto : INotifyMessageDto
    {
        public string Content { get; set; }
    }
}
