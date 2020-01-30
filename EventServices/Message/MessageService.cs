using System;
using System.Collections.Generic;
using System.Linq;
using EventDomain;


namespace EventServices
{
    public class MessageService : ISelector
    {
        public IMessage GetInstance(TimeSpan timeSpan)
        {
            ICondition condition = GetCondition(timeSpan);
            return (IMessage)Activator.CreateInstance(condition.TypeMessage);
        }

        private ICondition GetCondition(TimeSpan timeSpan)
        {
            List<ICondition> conditions = new List<ICondition>
            {
                new MessageByCondition {DateTimeCondition = timeSpan.Days > 30, TypeMessage = typeof(MessageMonth)},
                new MessageByCondition {DateTimeCondition = timeSpan.Days > 0, TypeMessage = typeof(MessageDay)},
                new MessageByCondition {DateTimeCondition = timeSpan.Hours > 0, TypeMessage = typeof(MessageHour)},
                new MessageByCondition {DateTimeCondition = timeSpan.Minutes >= 0, TypeMessage = typeof(MessageMinute)}
            };

            return conditions.FirstOrDefault(x => x.DateTimeCondition);
        }


    }
}
