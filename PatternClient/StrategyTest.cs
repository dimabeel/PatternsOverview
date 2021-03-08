using System;
using Strategy;
using System.Linq;

namespace PatternClient
{
    public class StrategyTest
    {
        public void Work()
        {
            int[] numbers = Enumerable.Range(0, 400).ToArray();

            ICalculateSumStrategy fastStrategy = new FastSumCalculateStrategy();
            var sumCalculator = new SumCalculator(fastStrategy);
            sumCalculator.CalculateSumAndShowIntoConsole(numbers);

            ICalculateSumStrategy slowStrategy = new SlowSumCalculateStrategy();
            sumCalculator.SetStrategy(slowStrategy);
            sumCalculator.CalculateSumAndShowIntoConsole(numbers);
        }
    }
}