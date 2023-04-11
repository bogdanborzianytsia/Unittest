using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Chainofduties;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string test = "Hi";
            string excpected = "Hi, how can i help you?";
            Handler h1 = new ConcreteHandler1();
            string actual = h1.HandleRequest(test);
            Assert.AreEqual(actual, excpected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string test = "Can you help me?";
            string excpected ="Yes i can help";
            Handler h2 = new ConcreteHandler2();
            string actual = h2.HandleRequest(test);
            Assert.AreEqual(actual, excpected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string test = "Can you plus numbers?";
            string excpected = "Sure i can do it";
            Handler h3 = new ConcreteHandler3();
            string actual = h3.HandleRequest(test);
            Assert.AreEqual(actual, excpected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string test = "how much will 8 add to 13?";
            string excpected = "it will be 21";
            Handler h4 = new ConcreteHandler4();
            string actual = h4.HandleRequest(test);
            Assert.AreEqual(actual, excpected);
        }
    }
}
