using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Frequency;

namespace NumberFrequencyTests
{
    [TestClass]
    public class NumberFrequencyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = NumberFrequency.CountFrequency(new int[] { 1, 2, 3, 1, 1, 3, 4, 5, 6, 0, 1, 1, 5, 3}, 1);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = NumberFrequency.CountFrequency(new int[] { 34, 123, 34843, 34203, 124, 3823, 329 }, 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = NumberFrequency.CountFrequency(new int[] { -1, -2, 4, 5, 343, 343, 343, 2, -1 }, -1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = NumberFrequency.CountFrequency(new int[] { 1111 }, 1111);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int result = NumberFrequency.CountFrequency(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0);
            Assert.AreEqual(8, result);
        }
    }
}
