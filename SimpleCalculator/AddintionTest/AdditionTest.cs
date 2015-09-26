using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AddintionTest()
        {
     
           Addintion MySum = new Addintion();
            int answer = MySum.Addintion(1, 1);
            Assert.AreEqual(answer, 2);
        }
    }
}
