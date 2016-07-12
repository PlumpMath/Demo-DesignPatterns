using System;
using DesignPatterns.Observer.Implementation.SubscribableContent;
using DesignPatterns.Observer.Implementation.Subscribers;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo-ObserverPattern - Observers of the Planet Express Newsletter (May or may not be inspired by Futurama).\n");

            // single source for deferring content creation 
            var subscribableContentFactory = new SubscribableContentFactory();
            var subscriberFactory = new SubscriberFactory();
            var personalityFactory = new PersonalityFactory();

            // create new content for observers to subscribe to 
            var content = subscribableContentFactory.CreateContent<PlanetExpressNewsletter>();

            // we all have personalities y'know - the constants were nice at first, but this is gawdy 
            var personalityOfFry = personalityFactory.Create<SubscriberPersonalization>(Constant.Fry.Name, Constant.Fry.OnSubMessage, Constant.Fry.OnUnsubMessage, Constant.Fry.OnContentReceived);
            var personalityOfBender = personalityFactory.Create<SubscriberPersonalization>(Constant.Bender.Name, Constant.Bender.OnSubMessage, Constant.Bender.OnUnsubMessage, Constant.Bender.OnContentReceived);
            var personalityOfZoidberg = personalityFactory.Create<SubscriberPersonalization>(Constant.Zoidberg.Name, Constant.Zoidberg.OnSubMessage, Constant.Zoidberg.OnUnsubMessage, Constant.Zoidberg.OnContentReceived);

            // subscriber - subscribe to content
            var fry = subscriberFactory.Create<Person>(personalityOfFry, content);
            var bender = subscriberFactory.Create<Robot>(personalityOfBender, content);

            // subscribable content - emit change
            content.Publish(Constant.Announcements.GoodNewsEveryone);

            // subscriber - subscribe to content explicitly 
            var zoidberg = subscriberFactory.Create<Decapodian>(personalityOfZoidberg); // Decapodian: a lobster-esque alien
            content.AddSubscriber(zoidberg);    // hey, why not zoidberg?!

            // subscribable content - emit change
            content.Publish(Constant.Announcements.IsThisThingOn);

            // subscriber - unsubscribe from content 
            content.RemoveSubscriber(bender);

            // subscribable content - emit change 
            content.Publish(Constant.Announcements.GoodNewsButNotOnTv);

            // Pausing the console for inspection
            Console.ReadLine();
        }
    }
}
