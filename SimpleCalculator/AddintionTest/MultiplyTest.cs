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

            Multiplication MyProduct = new Multiplication();
            int answer = MyProduct.Multiplication(5, 3);
            Assert.AreEqual(answer, 15);
        }
    }
}
