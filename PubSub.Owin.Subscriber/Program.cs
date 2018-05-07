using Microsoft.Owin.Hosting;
using PubSub.Modules.Subscriber.Dtos;
using System;
using System.Net.Http;

namespace PubSub.Owin.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Port No : ");
            var input = Console.ReadLine();

            string baseAddress = string.Format("http://localhost:{0}/", input);
            
            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.PostAsJsonAsync("http://localhost:63863/api/subscriber/register",
                    new SubscriberRegisterRequestDto
                    {
                        ListenerUrl = baseAddress + "api/message/listener"
                    }).Result;

                Console.WriteLine(response.StatusCode);
                Console.WriteLine("Listening");
                Console.ReadKey();
            }
        }
    }
}
