using System.Collections.Generic;
using DesignPatterns.Observer.Implementation.SubscribableContent;
using DesignPatterns.Observer.Interface;
using Moq;
using Xunit;

namespace DesignPatterns.Observer.Test.Implementation.SubscribableContent
{
    public class PlanetExpressNewsletterTests
    {
        [Fact]
        public void AddSubscriberShouldCallSubscribeOnPassedInSubscriberAndAddsSubscriberToInternalStoreOfSubscribers()
        {
            var sut = new PlanetExpressNewsletter();

            var mockSubscriber = new Mock<ISubscriber>();

            sut.AddSubscriber(mockSubscriber.Object);

            mockSubscriber.Verify(x => x.Subscribe(sut), Times.Once);

            Assert.True(sut.Subscribers.Contains(mockSubscriber.Object));
        }

        [Fact]
        public void RemoveSubscriberCallsUnsubscribeOnPassedInSubscriberAndRemovesSubscriberFromInternalStoreOfSubscribers()
        {
            var sut = new PlanetExpressNewsletter();

            var mockSubscriber = new Mock<ISubscriber>();

            sut.RemoveSubscriber(mockSubscriber.Object);

            mockSubscriber.Verify(x => x.Unsubscribe(sut), Times.Once);

            Assert.False(sut.Subscribers.Contains(mockSubscriber.Object));
        }

        [Fact]
        public void NotifySubscribersCallsRecieveContentOnEachSubscriberOfTheSubscription()
        {
            var sut = new PlanetExpressNewsletter();

            var firstMockSubscriber = new Mock<ISubscriber>();
            var secondMockSubscriber = new Mock<ISubscriber>();

            sut.AddSubscriber(firstMockSubscriber.Object);
            sut.AddSubscriber(secondMockSubscriber.Object);

            sut.NotifySubscribers();

            firstMockSubscriber.Verify(x => x.ReceiveContent(sut), Times.Once);
            secondMockSubscriber.Verify(x => x.ReceiveContent(sut), Times.Once);
        }

        [Fact]
        public void GetContentShouldReturnSameMessageThatWasPublished()
        {
            var sut = new PlanetExpressNewsletter();

            var expectedMessage = It.IsAny<string>();

            sut.Publish(expectedMessage);

            var actualMessage = sut.GetContent();

            Assert.Equal(actualMessage, expectedMessage);
        }

        [Fact]
        public void PublishShouldSetMessageValueAndNotifyAllSubscribersAddedToSubscribableContent()
        {
            var sut = new PlanetExpressNewsletter();

            var firstMockSubscriber = new Mock<ISubscriber>();
            var secondMockSubscriber = new Mock<ISubscriber>();
            var expectedMessage = It.IsAny<string>();

            sut.AddSubscriber(firstMockSubscriber.Object);
            sut.AddSubscriber(secondMockSubscriber.Object);

            sut.Publish(expectedMessage);

            firstMockSubscriber.Verify(x => x.ReceiveContent(sut), Times.Once);
            secondMockSubscriber.Verify(x => x.ReceiveContent(sut), Times.Once);
        }
    }
}
