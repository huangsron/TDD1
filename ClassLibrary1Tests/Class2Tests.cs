using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1Tests
{
    [TestClass]
    public class Class2Tests
    {
        [TestMethod]
        public void test_create_user_should_be_return_true()
        {
            var target = new UserManagement();

            var user = new UserModel()
            {
                Account = "Test",
                Password = "password"
            };

            var actual = target.Add(user);

            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_create_user_when_account_is_empty_should_be_return_false()
        {
            var target = new UserManagement();

            var user = new UserModel()
            {
                Account = "",
                Password = "password"
            };

            var actual = target.Add(user);

            var expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_create_user_when_account_is_test_and_password_is_empty_should_be_return_false()
        {
            var target = new UserManagement();

            var user = new UserModel()
            {
                Account = "test",
                Password = ""
            };

            var actual = target.Add(user);

            var expected = false;

            Assert.AreEqual(expected, actual);
        }
    }

    internal class UserModel
    {
        public string Account { get; internal set; }

        public string Password { get; internal set; }
    }

    internal class UserManagement
    {
        internal bool Add(UserModel user)
        {
            if (string.IsNullOrWhiteSpace(user.Account))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
            }
            return true;
        }
    }
}