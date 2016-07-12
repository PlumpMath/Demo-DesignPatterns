namespace DesignPatterns.Observer
{
    public static class Constant
    {
        public static class Fry
        {
            public static string Name => "Fry";

            public static string OnSubMessage => "";

            public static string OnUnsubMessage => "";

            public static string OnContentReceived => "";
        }

        public static class Bender
        {
            public static string Name => "Bender";

            public static string OnSubMessage => "";

            public static string OnUnsubMessage => "Fry cracked corn and I don’t care. Leela cracked corn I still don’t care. Bender cracked corn and he is great. Take that you stupid corn!";

            public static string OnContentReceived => "";
        }

        public static class Zoidberg
        {
            public static string Name => "Zoidberg";

            public static string OnSubMessage => "Hey, why not zoidberg?!";

            public static string OnUnsubMessage => "";

            public static string OnContentReceived => "";
        }

        public static class Announcements
        {
            public static string GoodNewsEveryone => "Professor Farnsworth: Good News Everyone!";

            public static string GoodNewsButNotOnTv => "Professor Farnsworth: Good news! There's a report on TV with some bad news.";

            public static string IsThisThingOn => "Professor Farnsworth: Is this thing on?";
        }
    }
}