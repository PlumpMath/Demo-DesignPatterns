using DesignPatterns.Observer.Implementation.SubscribableContent;
using Xunit;

namespace DesignPatterns.Observer.Test.Implementation.SubscribableContent
{
    public class SubscribableContentFactoryTests
    {
        [Fact]
        public void CreateContentShouldReturnInstanceOfSameTypeOfParameterT()
        {
            var sut = new SubscribableContentFactory();

            var reuslt = sut.CreateContent<PlanetExpressNewsletter>();

            Assert.Equal(reuslt.GetType(), typeof(PlanetExpressNewsletter));
        }
    }
}
