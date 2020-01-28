namespace EventosV2
{
    class Program
    {

        static void Main(string[] args)
        {
            string pathFile = @"C:\Users\jose.ek\Desktop\tarea.txt";

            IRead reader = new ReaderText(pathFile);
            IDateTimeService dtService = new DateTimeService();
            MessageHandler message = new MessageHandler(dtService, reader);

        }
    }
}
