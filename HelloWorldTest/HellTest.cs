using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class HellTest
    {
        [TestMethod]
        public void TestHello()
        {
            HelloWorld.Program hello = new HelloWorld.Program();
            string helloMessage = hello.Hello();

            Assert.AreEqual("Hello, World", helloMessage);
        }
    }
}
