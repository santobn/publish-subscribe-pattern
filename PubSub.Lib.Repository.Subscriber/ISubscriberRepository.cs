using PubSub.Lib.Repository.Subscriber.Operations;

namespace PubSub.Lib.Repository.Subscriber
{
    public interface ISubscriberRepository : IAddToRepositoryOperation, IGetAllFromRepositoryOperation
    {
    }
}
