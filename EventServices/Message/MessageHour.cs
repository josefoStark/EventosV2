using System;
using EventDomain;


namespace EventServices
{
    public class MessageHour : IMessage
    {
        public string BuildMessage(TimeSpan timeSpan)
        {
            return timeSpan.Hours + " hora(s)";
        }
    }
}
