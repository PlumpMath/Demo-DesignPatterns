using DesignPatterns.Observer.Implementation.Subscribers;

namespace DesignPatterns.Observer.Interface
{
    public interface ISubscriberFactory
    {
        T Create<T>(ISubscriberPersonalization subscriberPersonalization, ISubscribableContent content = null) where T : class, ISubscriber;
    }
}