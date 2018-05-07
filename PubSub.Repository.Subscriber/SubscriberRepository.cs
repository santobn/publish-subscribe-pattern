using System.Collections.Generic;
using PubSub.Lib.Repository.Subscriber;
using PubSub.Lib.Repository.Subscriber.Entities;

namespace PubSub.Repository.Subscriber
{
    public class SubscriberRepository : ISubscriberRepository
    {
        private List<ISubscriberDetailEntity> subscriberList;
        public SubscriberRepository()
        {
            subscriberList = new List<ISubscriberDetailEntity>();
        }

        public void Add(ISubscriberDetailEntity subscriberDetail)
        {
            subscriberList.Add(subscriberDetail);
        }

        public List<ISubscriberDetailEntity> GetAll()
        {
            return subscriberList;
        }
    }
}
