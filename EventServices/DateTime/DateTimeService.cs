using System;
using EventDomain;


namespace EventServices
{
    public class DateTimeService : IDateTimeService
    {
        public Func<DateTime> CurrentDateTime { get; set; }

        public DateTimeService()
        {
            CurrentDateTime = () => DateTime.Now;
        }

        public bool DateIsAfterCurrent(IDatos eventInfo)
        {
            DateTime dtCurrent = CurrentDateTime();
            int compareDate = dtCurrent.CompareTo(eventInfo.Date);
            return compareDate < 0;
        }

        public TimeSpan GetElapsedTime(IDatos eventInfo, bool dateIsAfterCurrent)
        {
            DateTime dtCurrent = CurrentDateTime();
            return dateIsAfterCurrent ? eventInfo.Date.Subtract(dtCurrent) : dtCurrent.Subtract(eventInfo.Date);
        }

    }
}