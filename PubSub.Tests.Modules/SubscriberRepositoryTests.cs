using PubSub.Repository.Subscriber.Entities;
using Xunit;
using System.Linq;
using PubSub.Repository.Subscriber;

namespace PubSub.Tests.Modules
{
    public class SubscriberRepositoryTests
    {
        private readonly SubscriberRepository subscriberRepository;
        public SubscriberRepositoryTests()
        {
            subscriberRepository = new SubscriberRepository();
        }

        [Fact]
        public void Count_ShouldReturnZero()
        {
            var count = subscriberRepository.GetAll().Count;
            Assert.Equal(0, count);
        }

        [Fact]
        public void Add_ShouldReturnItsValue()
        {
            var listenerUrl = "test";

            subscriberRepository.Add(new SubscriberDetailEntity
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
