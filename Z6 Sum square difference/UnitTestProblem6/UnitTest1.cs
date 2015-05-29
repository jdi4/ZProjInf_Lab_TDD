using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z6_Sum_square_difference;

namespace UnitTestProblem6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumOfFirst2Numbers()
        {
            int result = Problem6.CalculateSumOfFirstNNumbers(2);

            Assert.AreEqual(3, result);
        }
    }
}
