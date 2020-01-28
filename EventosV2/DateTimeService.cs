using System;

namespace EventosV2
{
    public class DateTimeService : IDateTimeService
    {
        public bool CompareIsPreviousDate(DateTime dateToCompare, DateTime currentDateTime)
        {
            int compareDate = currentDateTime.CompareTo(dateToCompare);
            return compareDate < 0;
        }

        public TimeSpan GetElapsedTime(DateTime majorTime, DateTime minorTime)
        {
            return majorTime.Subtract(minorTime);
        }
    }
}
