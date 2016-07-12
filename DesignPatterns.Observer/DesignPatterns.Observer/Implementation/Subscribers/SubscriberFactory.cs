using System;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    public class SubscriberFactory : ISubscriberFactory
    {
        public T Create<T>(ISubscriberPersonalization subscriberPersonalization, ISubscribableContent content = null) where T : class, ISubscriber
        {
            var concreteType = typeof(T);
            var instance = (T)Activator.CreateInstance(concreteType, subscriberPersonalization, content);
            content?.AddSubscriber(instance);
            return instance;
        }
    }
}