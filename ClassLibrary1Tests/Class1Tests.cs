using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void CreateTest()
        {
            var target = new Class1();
        }

        [TestMethod()]
        public void GetTest()
        {
            var target = new Class1();

            var actual = target.Get("test");

            var expected = "te";

            Assert.AreEqual(expected, actual);
        }
    }
}