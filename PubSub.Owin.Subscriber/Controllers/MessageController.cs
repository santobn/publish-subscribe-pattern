using Newtonsoft.Json;
using PubSub.Lib.Modules.Subscriber;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PubSub.Owin.Subscriber.Controllers
{
    public class MessageController : ApiController
    {
        private readonly IDisplayMessage displayMessage;
        public MessageController(IDisplayMessage displayMessage)
        {
            this.displayMessage = displayMessage;
        }

        [HttpPost]
        public HttpResponseMessage Listener(object messageListenerRequestDto)
        {
            displayMessage.Show(JsonConvert.SerializeObject(messageListenerRequestDto));
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
