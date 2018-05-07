namespace PubSub.Lib.Modules.Publisher
{
    public interface INotifySubscriber
    {
        bool NotifyAll(object notifyMessageDto);
    }
}
