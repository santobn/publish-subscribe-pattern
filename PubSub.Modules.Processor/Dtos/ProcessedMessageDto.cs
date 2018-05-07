using PubSub.Lib.Modules.Processor.Dtos;

namespace PubSub.Modules.Processor.Dtos
{
    public class ProcessedMessageDto : IProcessedMessageDto
    {
        public string ProcessedContent { get; set; }
    }
}
