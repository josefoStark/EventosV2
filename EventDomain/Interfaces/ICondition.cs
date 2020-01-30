using System;

namespace EventDomain
{
    public interface ICondition
    {
        bool DateTimeCondition { get; set; }

        Type TypeMessage { get; set; }

    }
}
