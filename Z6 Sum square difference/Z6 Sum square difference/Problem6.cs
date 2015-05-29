using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6_Sum_square_difference
{
    public class Problem6
    {
        /// Public: Calculate sum of the first n natural numbers.
        ///
        /// n - nth number
        ///
        /// Examples
        ///
        ///     CalculateSumOfFirstNNumbers(2)
        ///     # => 3
        ///     CalculateSumOfFirstNNumbers(10)
        ///     # => 55
        ///
        ///    Returns sum of the first n natural numbers
        public static int CalculateSumOfFirstNNumbers(int n)
        {
            return (n * (n + 1)) / 2;
        }


        /// Public: Calculate sum of the squares of the first n natural numbers.
        ///
        /// n - nth number
        ///
        /// Examples
        ///
        ///     CalculateSumOfSquaresOfFirstNNumbers(2)
        ///     # => 5
        ///     CalculateSumOfSquaresOfFirstNNumbers(10)
        ///     # => 385
        ///
        ///    Returns sum of the squares of the first n natural numbers
        public static int CalculateSumOfSquaresOfFirstNNumbers(int n)
        {
            return ((n) * (n + 1) * (2 * n + 1)) / 6;
        }

        public static int FindDifferenceBetweenSumOfSquaresAndSquareOfSum(int n)
        {
            int normalSum = CalculateSumOfFirstNNumbers(n);
            return normalSum * normalSum - CalculateSumOfSquaresOfFirstNNumbers(n);
        }

        public static string Solve(int n)
        {
            if (n < 1)
            {
                return "The number must be equal to or greater than 1";
            }
            else
            {
                int solution = Problem6.FindDifferenceBetweenSumOfSquaresAndSquareOfSum(n);
                return String.Format("The difference between the sum of the squares of the first {0} natural numbers and the square of the sum is {1}",
                                n, solution);
            }  
        }
    }
}
