using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloToYou;

namespace HelloTests
{
    [TestClass]
    public class HelloTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Hello.Greet("Pesho");
            Assert.AreEqual("Hello, Pesho!", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = Hello.Greet("my friend");
            Assert.AreEqual("Hello, my friend!", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result = Hello.Greet("John");
            Assert.AreEqual("Hello, John!", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string result = Hello.Greet("dear");
            Assert.AreEqual("Hello, dear!", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string result = Hello.Greet("Anna");
            Assert.AreEqual("Hello, Anna!", result);
        }
    }
}
