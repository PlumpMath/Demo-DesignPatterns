using System;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    public class SubscriberPersonalization : ISubscriberPersonalization
    {
        private readonly string _name;
        private readonly string _onSubscribeMessage;
        private readonly string _onUnsubscribeMessage;
        private readonly string _onContentReceived;

        public SubscriberPersonalization(string name, string onSubscribeMessage, string onUnsubscribeMessage, string onContentReceived)
        {
            _name = name;
            _onSubscribeMessage = onSubscribeMessage;
            _onUnsubscribeMessage = onUnsubscribeMessage;
            _onContentReceived = onContentReceived;
        }

        public string Name() => _name;

        public string OnSubscribeMessage() => _onSubscribeMessage;

        public string OnUnsubscribeMessage() => _onUnsubscribeMessage;

        public void OnSubscribe()
        {
            Console.WriteLine($"Subscribed by {Name()}: {OnSubscribeMessage()}");
        }

        public void OnUnsubscribe()
        {
            Console.WriteLine($"Unsubscription by {Name()}: {OnUnsubscribeMessage()}");
        }

        public void OnContentReceived(ISubscribableContent content)
        {
            Console.WriteLine($"Content Received by {Name()}: {content.GetContent()}");
        }
    }
}
