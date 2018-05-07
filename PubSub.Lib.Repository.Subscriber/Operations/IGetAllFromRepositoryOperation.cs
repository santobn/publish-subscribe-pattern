using PubSub.Lib.Repository.Subscriber.Entities;
using System.Collections.Generic;

namespace PubSub.Lib.Repository.Subscriber.Operations
{
    public interface IGetAllFromRepositoryOperation
    {
        List<ISubscriberDetailEntity> GetAll();
    }
}
