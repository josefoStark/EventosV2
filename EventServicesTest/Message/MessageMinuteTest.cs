using System;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{
    [TestClass]
    public class MessageMinuteTest
    {
        [TestMethod]
        public void BuildMessage_TimeSpanMinute_StringWithMinute()
        {
            TimeSpan timeSpan = new TimeSpan(23, 10, 5, 1);
            MessageMinute messageMinute = new MessageMinute();

            string result = messageMinute.BuildMessage(timeSpan);

            Assert.AreEqual(timeSpan.Minutes + " minuto(s)", result);
        }
    }
}
