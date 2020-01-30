using System;

namespace EventDomain
{
    public interface IDatos
    {
        string Name { get; set; }

        string OriginalDateTime { get; set; }

        DateTime Date { get; }



    }
}
