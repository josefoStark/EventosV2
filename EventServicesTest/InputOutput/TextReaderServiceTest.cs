using System.Linq;
using EventServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventServicesTest
{
    [TestClass]
    public class TextReaderServiceTest
    {
        [TestMethod]
        public void GetListEvent_TwoLines_TwoEvents()
        {
            TextReaderService textReader = new TextReaderService("");

            textReader.Lines = () => new string[] { "Event1,2020/01/12", "Event2,2020/02/12" };

            Assert.AreEqual(2, textReader.GetListEvent().Count);
        }

        [TestMethod]
        public void GetListEvent_GetNameEvent_Event1()
        {
            TextReaderService textReader = new TextReaderService("");


            textReader.Lines = () => new string[] { "Event1,2020/01/12" };

            Assert.AreEqual("Event1", textReader.GetListEvent().FirstOrDefault().Name);
        }
    }
}
