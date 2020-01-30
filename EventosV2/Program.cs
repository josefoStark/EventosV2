using EventDomain;
using EventServices;

namespace EventApp
{
    class Program
    {
        static void Main()
        {
            string pathFile = @"C:\Users\jose.ek\Desktop\tarea.txt";
            IRead reader = new TextReaderService(pathFile);
            IDateTimeService dtService = new DateTimeService();
            ISelector selectorMessage = new MessageService();
            EventProcessingHandler eventHandler = new EventProcessingHandler(dtService, reader, selectorMessage);
            DisplayService display = new DisplayService();
            display.ShowMessages(eventHandler.ListOfMessages());
        }
    }

}
