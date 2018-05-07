using PubSub.Lib.Modules.Processor;
using PubSub.Lib.Modules.Processor.Dtos;
using PubSub.Modules.Processor.Dtos;

namespace PubSub.Modules.Processor
{
    public class MessageProcessor : IMessageProcessor
    {
        public IProcessedMessageDto Process(IInputMessageDto inputMessageDto)
        {
            return new ProcessedMessageDto
            {
                ProcessedContent = inputMessageDto.Content
            };
        }
    }
}
