
using System;
using System.Collections.Generic;
using System.Linq;
using EventDomain;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventServicesTest
{
    [TestClass]
    public class EventHandlerTest
    {
        [TestMethod]
        public void Constructor()
        {
            Mock<IDateTimeService> iDateTime = new Mock<IDateTimeService>();
            Mock<IRead> iRead = new Mock<IRead>();
            Mock<ISelector> iSelector = new Mock<ISelector>();

            var eventHandler = new EventProcessingHandler(iDateTime.Object, iRead.Object, iSelector.Object);

            Assert.IsInstanceOfType(eventHandler, typeof(EventProcessingHandler));
        }

        [TestMethod]
        public void ListOfMessages_BuildMessage_CorrectMessage()
        {

            EventInformation eventInfo = new EventInformation { Name = "Event1", OriginalDateTime = "2020/02/01" };

            Mock<IDateTimeService> iDateTime = new Mock<IDateTimeService>();
            Mock<IRead> iRead = new Mock<IRead>();
            Mock<ISelector> iSelector = new Mock<ISelector>();

            iRead.Setup(m => m.GetListEvent()).Returns(new List<IDatos> { eventInfo });
            iDateTime.Setup(m => m.DateIsAfterCurrent(It.IsAny<IDatos>())).Returns(true);
            iDateTime.Setup(m => m.GetElapsedTime(It.IsAny<IDatos>(), It.IsAny<bool>())).Returns(new TimeSpan(2, 0, 0, 0));
            iSelector.Setup(m => m.GetInstance(It.IsAny<TimeSpan>())).Returns(new MessageDay());

            var eventHandler = new EventProcessingHandler(iDateTime.Object, iRead.Object, iSelector.Object);
            string actual = eventHandler.ListOfMessages().FirstOrDefault();

            string expected = $"{eventInfo.Name},{eventInfo.OriginalDateTime} ocurrirá dentro de 2 día(s)";

            Assert.AreEqual(expected, actual);

        }
    }
}
