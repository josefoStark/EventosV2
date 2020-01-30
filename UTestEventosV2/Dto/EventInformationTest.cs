using System;
using EventDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventDomainTest
{
    [TestClass]
    public class EventInformationTest
    {
        [TestMethod]
        public void Name_GetSet_TestString()
        {
            EventInformation eventInformation = new EventInformation { Name = "TestString" };
            Assert.AreEqual("TestString", eventInformation.Name);
        }

        [TestMethod]
        public void OriginalDateTime_GetSet_TestString()
        {
            EventInformation eventInformation = new EventInformation { OriginalDateTime = "TestString" };
            Assert.AreEqual("TestString", eventInformation.OriginalDateTime);
        }

        [TestMethod]
        public void DateTime_GetSet_DateTimeCorrect()
        {
            EventInformation eventInformation = new EventInformation { OriginalDateTime = "25/01/2020" };
            Assert.AreEqual(new DateTime(2020, 01, 25), eventInformation.Date);
        }
    }
}
