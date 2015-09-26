using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;


namespace CalculatorTest
{
    [TestClass]
    public class MultiplyTest
    {
        [TestMethod]
        public void MultiplicationTest()
        {

            Multiply MyProduct = new Multiply();
            int answer = MyProduct.Multiply(5, 3);
            Assert.AreEqual(answer, 15);
        }
    }
}
