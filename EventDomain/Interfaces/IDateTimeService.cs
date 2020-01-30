using System;

namespace EventDomain
{
    public interface IDateTimeService
    {
        bool DateIsAfterCurrent(IDatos eventInfo);

        TimeSpan GetElapsedTime(IDatos eventInfo, bool dateIsAfterCurrent);
    }
}