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

        public static int CalculateSumOfSquaresOfFirstNNumbers(int p)
        {
            throw new NotImplementedException();
        }
    }
}
