using PubSub.Lib.Modules.Processor.Dtos;

namespace PubSub.Lib.Modules.Processor
{
    public interface IMessageProcessor
    {
        IProcessedMessageDto Process(IInputMessageDto inputMessageDto);
    }
}
