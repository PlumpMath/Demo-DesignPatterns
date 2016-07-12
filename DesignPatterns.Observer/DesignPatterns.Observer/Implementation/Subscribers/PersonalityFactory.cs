using System;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    internal class PersonalityFactory
    {
        public T Create<T>(string name, string onSubMessage, string onUnsubMessage, string onContentReceived) where T : class, ISubscriberPersonalization
        {
            var type = typeof(T);
            return (T) Activator.CreateInstance(type, name, onSubMessage, onUnsubMessage, onContentReceived);
        }
    }
}