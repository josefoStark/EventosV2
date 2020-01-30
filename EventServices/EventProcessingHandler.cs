using System;
using System.Collections.Generic;
using EventDomain;


namespace EventServices
{
    public class EventProcessingHandler
    {
        private readonly IDateTimeService _dateTimeService;
        private readonly IRead _reader;
        private readonly ISelector _selector;

        public EventProcessingHandler(IDateTimeService dateTimeService, IRead reader, ISelector selector)
        {
            _dateTimeService = dateTimeService;
            _reader = reader;
            _selector = selector;
        }

        public List<string> ListOfMessages()
        {
            List<IDatos> lstEvents = _reader.GetListEvent();
            List<string> lstMessages = new List<string>();

            foreach (var item in lstEvents)
            {
                bool isDateAfterCurrent = _dateTimeService.DateIsAfterCurrent(item);
                TimeSpan timeElapsed = _dateTimeService.GetElapsedTime(item, isDateAfterCurrent);
                lstMessages.Add(BuildMessage(item.Name, item.OriginalDateTime, timeElapsed, isDateAfterCurrent));
            }

            return lstMessages;
        }


        private string BuildMessage(string name, string strDateTime, TimeSpan timeElapsed, bool isDateAfterCurrent)
        {
            string cadena = isDateAfterCurrent ? "ocurrirá dentro de" : "ocurrió hace";
            IMessage message = _selector.GetInstance(timeElapsed);
            return $"{name},{strDateTime} {cadena} {message.BuildMessage(timeElapsed)}";
        }

    }

}
