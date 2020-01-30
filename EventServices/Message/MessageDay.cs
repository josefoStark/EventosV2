using System;
using EventDomain;


namespace EventServices
{
    public class MessageDay : IMessage
    {
        public string BuildMessage(TimeSpan timeSpan)
        {
            return timeSpan.Days + " día(s)";
        }
    }
}
