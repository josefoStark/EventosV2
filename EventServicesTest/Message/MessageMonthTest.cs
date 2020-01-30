using System;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{
    [TestClass]
    public class MessageMonthTest
    {
        [TestMethod]
        public void BuildMessage_TimeSpanMinute_StringWithMinute()
        {
            TimeSpan timeSpan = new TimeSpan(23, 10, 5, 1);
            MessageMonth messageMonth = new MessageMonth();

            string result = messageMonth.BuildMessage(timeSpan);

            Assert.AreEqual(timeSpan.Days / 30 + " mes(es)", result);
        }
    }
}
