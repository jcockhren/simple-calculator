using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void DivisonTest()
        {

            Divison MyQuotient = new Divison();
            int answer = MyQuotient.DivideNum(15, 3);
            Assert.AreEqual(answer, 5);
        }
    }
}
