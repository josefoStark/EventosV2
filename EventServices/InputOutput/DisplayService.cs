using System;
using System.Collections.Generic;
using EventDomain;

namespace EventServices
{
    public class DisplayService : IShow
    {
        public void ShowMessages(List<string> lstMessages)
        {
            ShowMessage("Lista de eventos: ");

            foreach (string item in lstMessages)
            {
                ShowMessage(item);
            }

            ShowMessage("Press any key to exit.");

            WaitApplication();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void WaitApplication()
        {
            Console.ReadKey();
        }
    }
}
