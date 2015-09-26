using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace CalculatorTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AddintionTest()
        {
     
           addition MySum = new addition();
            int answer = MySum.AddNum(1, 1);
            Assert.AreEqual(answer, 2);
        }
    }
}
