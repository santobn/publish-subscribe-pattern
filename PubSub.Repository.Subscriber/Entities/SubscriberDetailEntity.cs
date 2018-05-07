using PubSub.Lib.Repository.Subscriber.Entities;

namespace PubSub.Repository.Subscriber.Entities
{
    public class SubscriberDetailEntity : ISubscriberDetailEntity
    {
        public string ListenerUrl { get; set; }
    }
}
