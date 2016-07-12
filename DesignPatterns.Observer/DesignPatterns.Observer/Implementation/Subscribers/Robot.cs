using System;
using System.Collections.Generic;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    public class Robot : ISubscriber
    {
        private readonly ISubscriberPersonalization _subscriberPersonalization;

        public List<ISubscribableContent> SubscribedContents { get; }

        public Robot(ISubscriberPersonalization subscriberPersonalization, ISubscribableContent content)
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
            SubscribedContents.Remove(content);
        }

        public void ReceiveContent(ISubscribableContent content)
        {
            _subscriberPersonalization.OnContentReceived(content);
        }
    }
}