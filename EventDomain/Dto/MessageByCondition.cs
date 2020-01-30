using System;


namespace EventDomain
{
    public class MessageByCondition : ICondition
    {
        public bool DateTimeCondition { get; set; }
        public Type TypeMessage { get; set; }
    }

  
}
