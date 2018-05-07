using PubSub.Lib.Modules.Publisher;
using PubSub.Lib.Repository.Subscriber;
using PubSub.Modules.Publisher;
using PubSub.Modules.Publisher.Dto;
using PubSub.Repository.Subscriber;
using System.Linq;
using Xunit;

namespace PubSub.Tests.Modules
{
    public class RegisterSubscriberTests
    {
        private readonly ISubscriberRepository subscriberRepository;
        private readonly IRegisterSubscriber registerSubscriber;
        public RegisterSubscriberTests()
        {
            subscriberRepository = new SubscriberRepository();
            registerSubscriber = new RegisterSubscriber(subscriberRepository);
        }


        [Fact]
        public void Register_ShouldReturnItsValue()
        {
            var listenerUrl = "test";

            registerSubscriber.Register(new SubscriberDetailDto
            {
                ListenerUrl = listenerUrl
            });

            var count = subscriberRepository.GetAll().Count;
            Assert.Equal(1, count);

            var subscriberDetail = subscriberRepository.GetAll().First();
            Assert.Equal(listenerUrl, subscriberDetail.ListenerUrl);
        }
    }
}
