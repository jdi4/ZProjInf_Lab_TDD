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

        [TestMethod]
        public void TestSumOfFirst10Numbers()
        {
            int result = Problem6.CalculateSumOfFirstNNumbers(10);

            Assert.AreEqual(55, result);
        }

        [TestMethod]
        public void TestSumOfSquaresOfFirst2Numbers()
        {
            int result = Problem6.CalculateSumOfSquaresOfFirstNNumbers(2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSumOfSquaresOfFirst10Numbers()
        {
            int result = Problem6.CalculateSumOfSquaresOfFirstNNumbers(10);

            Assert.AreEqual(385, result);
        }

        [TestMethod]
        public void TestDifferenceBetweenSumOfSquaresAndSquareOfSumOfFirst2Numbers()
        {
            int result = Problem6.FindDifferenceBetweenSumOfSquaresAndSquareOfSum(2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestDifferenceBetweenSumOfSquaresAndSquareOfSumOfFirst10Numbers()
        {
            int result = Problem6.FindDifferenceBetweenSumOfSquaresAndSquareOfSum(10);

            Assert.AreEqual(2640, result);
        }
    }
}
