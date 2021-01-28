using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAddTypeEquipment1
    {
        [TestMethod]
        public void TestAddTypeEquipment()
        {
            string name = "Test1";
            int expected = 1;

            TypeEquipmentWindow typeEquipment = new TypeEquipmentWindow();
            int actual = typeEquipment.FunAdd(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
