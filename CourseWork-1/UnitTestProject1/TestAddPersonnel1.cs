using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAddPersonnel1
    {
        [TestMethod]
        public void TestAddPersonnel()
        {
            string last = "test", first = "test", middle = "test", post = "test";
            int expected = 1;

            PersonnelWindow personnelWindow = new PersonnelWindow();
            int actual = personnelWindow.FunAdd(last, first, middle, post);
            Assert.AreEqual(expected, actual);
        }
    }
}
