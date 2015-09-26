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

            Divison MyProduct = new Divison();
            int answer = MyProduct.DivideNum(15, 3);
            Assert.AreEqual(answer, 5);
        }
    }
}
