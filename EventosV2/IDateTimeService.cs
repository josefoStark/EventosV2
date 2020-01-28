using System;

namespace EventosV2
{
    public interface IDateTimeService
    {
        bool CompareIsPreviousDate(DateTime dateToCompare, DateTime currentDateTime);

        TimeSpan GetElapsedTime(DateTime majorTime, DateTime minorTime);



    }
}
