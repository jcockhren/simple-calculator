using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class ModulusTest
    {
        [TestMethod]
        public void ModTest()
        {

            Modulus.ModulusNum([]);
           // int answer = ModulusNum(15, 3);
            Assert.AreEqual(answer, 0);
        }
    }
}
