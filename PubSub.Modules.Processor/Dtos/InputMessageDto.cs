using PubSub.Lib.Modules.Processor.Dtos;

namespace PubSub.Modules.Processor.Dtos
{
    public class InputMessageDto : IInputMessageDto
    {
        public string Content { get; set; }
    }
}
