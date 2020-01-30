using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using EventDomain;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventServicesTest
{
    [TestClass]
    public class DateTimeServiceTest
    {
        [DataRow(2019, false)]
        [DataRow(2022, true)]
        [TestMethod]
        public void DateIsAfterCurrent_Year_Expected(int year, bool expected)
        {
            Mock<IDatos> idatos = new Mock<IDatos>();
            DateTimeService dateTimeService = new DateTimeService();
            idatos.Setup(m => m.Date).Returns(new DateTime(year, 1, 1));
            dateTimeService.CurrentDateTime = () => new DateTime(2020, 1, 1);
            var result = dateTimeService.DateIsAfterCurrent(idatos.Object);

            Assert.AreEqual(expected, result);
        }

        [DataRow(5, 15, false)]
        [DataRow(30, 10, true)]
        [TestMethod]
        public void GetElapsedTime(int day, int elapsedTime, bool isAfterCurrent)
        {
            Mock<IDatos> idatos = new Mock<IDatos>();
            DateTimeService dateTimeService = new DateTimeService();
            idatos.Setup(m => m.Date).Returns(new DateTime(2020, 1, day));
            dateTimeService.CurrentDateTime = () => new DateTime(2020, 1, 20);
            var result = dateTimeService.GetElapsedTime(idatos.Object, isAfterCurrent);


            TimeSpan timeSpan = new TimeSpan(elapsedTime, 0, 0, 0);

            Assert.AreEqual(timeSpan, result);
        }


    }
}
