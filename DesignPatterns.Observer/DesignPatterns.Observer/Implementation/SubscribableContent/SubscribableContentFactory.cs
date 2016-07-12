using System;
using DesignPatterns.Observer.Interface;

namespace DesignPatterns.Observer.Implementation.SubscribableContent
{
    public class SubscribableContentFactory : ISubscribableContentFactory
    {
        public T CreateContent<T>() where T : class, ISubscribableContent
        {
            var type = typeof(T);
            return (T) Activator.CreateInstance(type);
        }
    }
}