using System;

namespace EventDomain
{
    public interface IMessage
    {
        string BuildMessage(TimeSpan timeSpan);
    }
}
