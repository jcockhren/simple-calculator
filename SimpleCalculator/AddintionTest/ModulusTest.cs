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

           Modulus MyMod = new Modulus();
            int answer = MyMod.ModulusNum(15, 3);
            Assert.AreEqual(answer, 0);
        }
    }
}
