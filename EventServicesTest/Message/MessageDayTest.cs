using System;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{
    [TestClass]
    public class MessageDayTest
    {
        [TestMethod]
        public void BuildMessage_TimeSpanDay_StringWithDay()
        {
            TimeSpan timeSpan = new TimeSpan(23, 10, 5, 1);
            MessageDay messageDay = new MessageDay();

            string result = messageDay.BuildMessage(timeSpan);

            Assert.AreEqual(timeSpan.Days + " día(s)", result);
        }
    }
}
