using PubSub.Lib.Modules.Publisher;
using PubSub.Lib.Modules.Publisher.Dto;
using PubSub.Lib.Repository.Subscriber;
using PubSub.Repository.Subscriber.Entities;

namespace PubSub.Modules.Publisher
{
    public class RegisterSubscriber : IRegisterSubscriber
    {
        private readonly ISubscriberRepository subscriberRepository;
        public RegisterSubscriber(ISubscriberRepository subscriberRepository)
        {
            this.subscriberRepository = subscriberRepository;
        }

        public void Register(ISubscriberDetailDto subscriberDetailDto)
        {
            subscriberRepository.Add(new SubscriberDetailEntity
            {
                ListenerUrl = subscriberDetailDto.ListenerUrl
            });
        }
    }
}
