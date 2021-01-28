using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAuthrization1
    {
        [TestMethod]
        public void TestAuthrization()
        {
            var page = new AuthrizationWindow();
            Assert.IsTrue(page.Auth("admin", "admin1"));
            Assert.IsTrue(page.Auth("serj", "123"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));
            Assert.IsFalse(page.Auth("1234567890", "1234567890"));
        }    
    }
}
