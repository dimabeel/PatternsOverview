using System;
using System.Linq;

namespace Strategy
{
    public class FastSumCalculateStrategy : ICalculateSumStrategy
    {
        public int CalculateSum(int[] nums)
        {
            return nums.Sum(); 
        }
    }
}
