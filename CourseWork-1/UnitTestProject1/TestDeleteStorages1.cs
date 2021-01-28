using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestDeleteStorages1
    {
        [TestMethod]
        public void TestDeleteStorage()
        {
            StoragesWindow storagesWindow = new StoragesWindow();
            string iddel = "5004";
            int i = Convert.ToInt32(iddel);
            int expected = 1;
            int actual = storagesWindow.FunDelete(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
