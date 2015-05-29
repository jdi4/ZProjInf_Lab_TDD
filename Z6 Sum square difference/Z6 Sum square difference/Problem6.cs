using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6_Sum_square_difference
{
    public class Problem6
    {
        public static int CalculateSumOfFirstNNumbers(int n)
        {
            int sum = 0;
            for (int i = 1 ; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
