using PubSub.Api.Publisher.Dtos;
using PubSub.Lib.Modules.Publisher;
using PubSub.Modules.Publisher.Dto;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PubSub.Api.Publisher.Controllers
{
    public class SubscriberController : ApiController
    {
        private readonly IRegisterSubscriber registerSubscriber;

        public SubscriberController(IRegisterSubscriber registerSubscriber)
        {
            this.registerSubscriber = registerSubscriber;
        }

        [HttpPost]
        public HttpResponseMessage Register([FromBody]SubscriberRegisterRequestDto subscriberRegisterRequestDto)
        {
            registerSubscriber.Register(new SubscriberDetailDto
            {
                ListenerUrl = subscriberRegisterRequestDto.ListenerUrl
            });

            return Request.CreateResponse(HttpStatusCode.OK, subscriberRegisterRequestDto.ListenerUrl);
        }
    }
}
