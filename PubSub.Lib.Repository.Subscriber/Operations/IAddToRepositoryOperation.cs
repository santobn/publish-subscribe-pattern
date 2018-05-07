using PubSub.Lib.Repository.Subscriber.Entities;

namespace PubSub.Lib.Repository.Subscriber.Operations
{
    public interface IAddToRepositoryOperation
    {
        void Add(ISubscriberDetailEntity subscriberDetail);
    }
}
