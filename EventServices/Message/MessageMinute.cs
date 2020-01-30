using System;
using EventDomain;


namespace EventServices
{
    public class MessageMinute : IMessage
    {
        public string BuildMessage(TimeSpan timeSpan)
        {
            return timeSpan.Minutes + " minuto(s)";
        }
    }
}
