namespace DesignPatterns.Observer.Interface
{
    public interface ISubscribableContentFactory
    {
        T CreateContent<T>() where T : class, ISubscribableContent;
    }
}