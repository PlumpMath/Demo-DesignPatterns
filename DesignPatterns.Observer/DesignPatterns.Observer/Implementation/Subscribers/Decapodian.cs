using System;
using System.Collections.Generic;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    // Decapodian: a lobster-esque alien
    public class Decapodian : ISubscriber
    {
        private readonly ISubscriberPersonalization _subscriberPersonalization;

        public List<ISubscribableContent> SubscribedContents { get; }

        public Decapodian(ISubscriberPersonalization subscriberPersonalization, ISubscribableContent content)
        {
            _subscriberPersonalization = subscriberPersonalization;
            SubscribedContents = new List<ISubscribableContent> {content};
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