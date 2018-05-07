using Newtonsoft.Json;
using PubSub.Lib.Modules.Publisher;
using PubSub.Lib.Repository.Subscriber;
using System;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Threading.Tasks;

namespace PubSub.Modules.Publisher
{
    public class NotifySubscriber : INotifySubscriber
    {
        public readonly ISubscriberRepository subscriberRepository;
        public NotifySubscriber(ISubscriberRepository subscriberRepository)
        {
            this.subscriberRepository = subscriberRepository;
        }

        public bool NotifyAll(object notifyMessageDto)
        {
            var subsribers = subscriberRepository.GetAll();
            var httpClient = new HttpClient();
            var exceptions = new ConcurrentQueue<Exception>();

            Parallel.ForEach(subsribers, s =>
            {
                try
                {
                    using (var requestContent = new StringContent(JsonConvert.SerializeObject(notifyMessageDto),
                        System.Text.Encoding.UTF8, "application/json"))
                    {
                        var responseTask = httpClient.PostAsync(s.ListenerUrl, requestContent).Result;
                    }
                }
                catch (Exception e) { exceptions.Enqueue(e); }
            });
            return (exceptions.Count == 0);
        }
    }
}
