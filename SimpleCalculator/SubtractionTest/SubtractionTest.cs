using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SubtractionTest
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void subtractionTest()
        {

            Subtraction MyDifference = new Subtraction();
            int answer = MyDifference.Subtraction(5, 3);
            Assert.AreEqual(answer, 2);
        }
    }
}
