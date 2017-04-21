using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab16
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, Lab16Project.isPrime(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Lab16Project.isPrime(3));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, Lab16Project.isPrime(5));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(6));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, Lab16Project.isPrime(7));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(8));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(9));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(false, Lab16Project.isPrime(10));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(true, Lab16Project.isPrime(11));
        }
    }
}
