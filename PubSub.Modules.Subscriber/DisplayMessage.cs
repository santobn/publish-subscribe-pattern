using PubSub.Lib.Modules.Subscriber;
using System;

namespace PubSub.Modules.Subscriber
{
    public class DisplayMessage : IDisplayMessage
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
