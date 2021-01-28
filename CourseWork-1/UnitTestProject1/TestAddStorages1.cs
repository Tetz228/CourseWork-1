using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAddStorages1
    {
        [TestMethod]
        public void TestAddStorages()
        {
            string name = "Test1";
            int expected = 1;

            StoragesWindow typeEquipment = new StoragesWindow();
            int actual = typeEquipment.FunAdd(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
