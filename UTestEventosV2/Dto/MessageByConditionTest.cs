using System;
using EventDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventDomainTest
{
    [TestClass]
    public class MessageByConditionTest
    {
        [TestMethod]
        public void DateTimeCondition_GetSet_True()
        {
            MessageByCondition messageByCondition = new MessageByCondition { DateTimeCondition = true };
            Assert.IsTrue(messageByCondition.DateTimeCondition);
        }

        [TestMethod]
        public void TypeMessage_GetSet_TypeInt()
        {
            MessageByCondition messageByCondition = new MessageByCondition { TypeMessage = typeof(int) };
            Assert.AreEqual(typeof(int), messageByCondition.TypeMessage);
        }
    }
}
