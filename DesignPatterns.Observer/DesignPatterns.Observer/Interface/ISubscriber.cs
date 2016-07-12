namespace DesignPatterns.Observer.Interface
{
    public interface ISubscriber
    {
        void Subscribe(ISubscribableContent content);

        void Unsubscribe(ISubscribableContent content);

        void ReceiveContent(ISubscribableContent content);
    }
}