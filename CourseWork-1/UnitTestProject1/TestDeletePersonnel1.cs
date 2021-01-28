using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestDeletePersonnel1
    {
        [TestMethod]
        public void TestDeletePersonnel()
        {
            PersonnelWindow personnelWindow = new PersonnelWindow();
            string iddel = "4005";
            int i = Convert.ToInt32(iddel);
            int expected = 1;
            int actual = personnelWindow.FunDelete(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
