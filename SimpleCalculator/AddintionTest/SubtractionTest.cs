using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;


namespace SubtractionTest
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public static void SubtractNum()
        {
            //pt.InvokeStatic
            var MyDifference = new Subtraction.InvokeStatic.SubtractNum();
            int answer = MyDifference.SubtractNum(5, 3);
            Assert.AreEqual(answer, 2);
        }
    }
}
