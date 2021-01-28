using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovay;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAddUsers1
    {
        [TestMethod]
        public void TestAddUsers()
        {
            string login = "test", password = "test", post = "test", last = "test", first = "test", middle = "test";
            int expected = 1;

            UsersWindow usersWindow = new UsersWindow();
            int actual = usersWindow.FunAdd(login, password, post, last, first, middle);
            Assert.AreEqual(expected, actual);
        }
    }
}
