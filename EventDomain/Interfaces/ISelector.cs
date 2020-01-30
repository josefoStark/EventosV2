using System;

namespace EventDomain
{
    public interface ISelector
    {
        IMessage GetInstance(TimeSpan timeSpan);
    }
}
