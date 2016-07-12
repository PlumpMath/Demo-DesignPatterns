namespace DesignPatterns.Observer.Interface
{
    public interface ISubscriptions
    {
        void Add(ISubscribableContent content);

        void Remove(ISubscribableContent content);

        void Get(ISubscribableContent content);
    }
}