using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestDeleteTypeEquipment1
    {
        [TestMethod]
        public void TestDeleteTypeEquipment()
        {
            TypeEquipmentWindow typeEquipmentWindow = new TypeEquipmentWindow();
            string iddel = "3008";
            int i = Convert.ToInt32(iddel);
            int expected = 1;
            int actual = typeEquipmentWindow.FunDelete(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
