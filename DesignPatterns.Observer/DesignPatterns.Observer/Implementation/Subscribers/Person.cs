using System.Collections.Generic;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    public class Person : ISubscriber
    {
        private readonly ISubscriberPersonalization _subscriberPersonalization;

        public List<ISubscribableContent> SubscribedContents { get; }

        public Person(ISubscriberPersonalization subscriberPersonalization, ISubscribableContent content)
        {
            _subscriberPersonalization = subscriberPersonalization;
            SubscribedContents = new List<ISubscribableContent>();

            if (content != null)
            {
                SubscribedContents.Add(content);
            }
        }

        public void Subscribe(ISubscribableContent content)
        {
            _subscriberPersonalization.OnSubscribe();
            SubscribedContents.Add(content);
        }

        public void Unsubscribe(ISubscribableContent content)
        {
            _subscriberPersonalization.OnUnsubscribe();
            content.RemoveSubscriber(this);
        }

        public void ReceiveContent(ISubscribableContent content)
        {
            _subscriberPersonalization.OnContentReceived(content);
        }
    }
}