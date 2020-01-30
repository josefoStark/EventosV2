using System;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{
    [TestClass]
    public class MessageHourTest
    {
        [TestMethod]
        public void BuildMessage_TimeSpanHour_StringWithHour()
        {
            TimeSpan timeSpan = new TimeSpan(23, 10, 5, 1);
            MessageHour messageHour = new MessageHour();

            string result = messageHour.BuildMessage(timeSpan);

            Assert.AreEqual(timeSpan.Hours + " hora(s)", result);
        }
    }
}
