using System;
using System.Threading;

namespace Strategy
{
    public class SlowSumCalculateStrategy : ICalculateSumStrategy
    {
        public int CalculateSum(int[] nums)
        {
            int result = 0;
            foreach(var num in nums)
            {
                result += num;
                Thread.Sleep(100);
            }

            return result;
        }
    }
}
