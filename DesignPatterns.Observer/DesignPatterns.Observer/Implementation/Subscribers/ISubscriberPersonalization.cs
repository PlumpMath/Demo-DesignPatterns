using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.Subscribers
{
    public interface ISubscriberPersonalization
    {
        void OnSubscribe();
        void OnUnsubscribe();
        void OnContentReceived(ISubscribableContent content);
    }
}