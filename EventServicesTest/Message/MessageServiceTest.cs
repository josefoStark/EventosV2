using System;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{

    [TestClass]
    public class MessageServiceTest
    {
        [DataRow(45, 10, 5, typeof(MessageMonth))]
        [DataRow(1, 10, 5, typeof(MessageDay))]
        [DataRow(0, 2, 5, typeof(MessageHour))]
        [DataRow(0, 0, 1, typeof(MessageMinute))]
        [TestMethod]
        public void GetInstance_Month_(int day, int hours, int minute, Type type)
        {
            TimeSpan timeSpan = new TimeSpan(day, hours, minute, 1);
            MessageService messageService = new MessageService();

            var result = messageService.GetInstance(timeSpan);

            Assert.IsInstanceOfType(result, type);
        }
    }
}
