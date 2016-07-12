namespace DesignPatterns.Observer.Interface
{
    public interface ISubscribableContent
    {
        void AddSubscriber(ISubscriber subscriber);

        void RemoveSubscriber(ISubscriber subscriber);

        void Publish(string message);

        void NotifySubscribers();

        string GetContent();
    }
}