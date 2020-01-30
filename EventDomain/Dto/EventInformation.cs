using System;

namespace EventDomain
{
    public class EventInformation : IDatos
    {
        public string Name { get; set; }

        public DateTime Date => DateTime.Parse(OriginalDateTime);

        public string OriginalDateTime { get; set; }
    }
}