namespace DesignPatterns.Observer.Interface
{
    public interface ISubscriberPersonalization
    {
        void OnSubscribe();
        void OnUnsubscribe();
        void OnContentReceived(ISubscribableContent content);
    }
}