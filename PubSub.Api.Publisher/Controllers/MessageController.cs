using PubSub.Api.Publisher.Dtos;
using PubSub.Lib.Modules.Processor;
using PubSub.Lib.Modules.Publisher;
using PubSub.Modules.Processor.Dtos;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PubSub.Api.Publisher.Controllers
{
    public class MessageController : ApiController
    {
        public readonly INotifySubscriber notifySubscriber;
        public readonly IMessageProcessor messageProcessor;
        public MessageController(INotifySubscriber notifySubscriber, IMessageProcessor messageProcessor)
        {
            this.notifySubscriber = notifySubscriber;
            this.messageProcessor = messageProcessor;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Send([FromBody] MessageSendRequestDto messageSendRequestDto)
        {
            var processedMessage = messageProcessor.Process(new InputMessageDto
            {
                Content = messageSendRequestDto.Content
            });
            notifySubscriber.NotifyAll(processedMessage);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
