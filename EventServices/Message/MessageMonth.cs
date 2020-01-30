using System;
using EventDomain;


namespace EventServices
{
    public class MessageMonth : IMessage
    {
        public string BuildMessage(TimeSpan timeSpan)
        {
            return timeSpan.Days / 30 + " mes(es)";
        }
    }
}
