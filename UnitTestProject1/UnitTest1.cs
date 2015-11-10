using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SImpleInterest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetSI()
        {
            SimpleInterest tt = new SimpleInterest();
            int output = tt.getSI(100,12,3);
            Assert.AreEqual(36,output);
        }
    }
}
