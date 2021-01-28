using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestDeleteUsers1
    {
        [TestMethod]
        public void TestDeleteUsers()
        {
            UsersWindow usersWindow = new UsersWindow();
            string iddel = "2004";
            int i = Convert.ToInt32(iddel);
            int expected = 1;
            int actual = usersWindow.FunDelete(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
