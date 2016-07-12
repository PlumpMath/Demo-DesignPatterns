using System.Collections.Generic;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.SubscribableContent
{
    public class PlanetExpressNewsletter : ISubscribableContent
    {
        private string _message;

        public PlanetExpressNewsletter()
        {
            Subscribers = new List<ISubscriber>();
        }

        public List<ISubscriber> Subscribers { get; }

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscriber.Subscribe(this);
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscriber.Unsubscribe(this);
            Subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.ReceiveContent(this);
            }
        }

        public void Publish(string message)
        {
            _message = message;
            NotifySubscribers();
        }

        public string GetContent()
        {
            return _message;
        }
    }
}