using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosV2
{
    public class MessageHandler
    {
        private readonly IDateTimeService _dateTimeService;
        private readonly IRead _reader;

        public MessageHandler(IDateTimeService dateTimeService, IRead reader)
        {
            _dateTimeService = dateTimeService;
            _reader = reader;
        }

        public void Handle(EventDTO eventDto)
        {
            _reader.GetListEvent();
            bool isCurrentDateMinor = _dateTimeService.CompareIsPreviousDate(eventDto.Date, DateTime.Now);
            TimeSpan timeElapsed = _dateTimeService.GetElapsedTime(DateTime.Now, eventDto.Date);

            if (isCurrentDateMinor)
            {
                timeElapsed = _dateTimeService.GetElapsedTime(eventDto.Date, DateTime.Now);
            }


        }
    }

}
