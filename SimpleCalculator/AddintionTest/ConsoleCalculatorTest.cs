using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class ConsoleCalculatorTest
    {
        [TestMethod]
        public void GetNumbersShouldReturnTwoStrings()
        {
            var calc = new ConsoleCalculator();
            var stringArray = calc.GetNumbers("12+16");
            var expected = new string[] {"12","16"};
            CollectionAssert.AreEqual(stringArray, expected);
           
        }

        [TestMethod]
        public void ShouldGetOperators()
        {
            var calc = new ConsoleCalculator();
            var op = calc.GetOperator("12-8");
            var expected = '-';
            Assert.AreEqual(expected, op);
        }
    }
}
