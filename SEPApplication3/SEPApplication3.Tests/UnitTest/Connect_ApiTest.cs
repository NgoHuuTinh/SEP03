using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEPApplication3.Connect;

namespace SEPApplication3.Tests.UnitTest
{
    [TestClass]
    public class Connect_ApiTest
    {
        [TestMethod]
        public void TestLogin()
        {
            var api = new Connect_API();
            var result0 = api.Login("phamngocduy", "tradristel");
            var result1 = api.Login("phamngocduy", "1234567890");
            Assert.AreEqual(0, result0.Code);
            Assert.AreEqual(1, result1.Code);
        }

        [TestMethod]
        public void TestGetCourse()
        {
            var api = new Connect_API();
            var result = api.GetCourse("ND");
            Assert.AreEqual(3, result.Data.Length);
        }

    }
}
