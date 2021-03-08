using System;

namespace Strategy
{
    public class SumCalculator
    {
        public SumCalculator(ICalculateSumStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(ICalculateSumStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void CalculateSumAndShowIntoConsole(int[] numbers)
        {
            int result = strategy.CalculateSum(numbers);
            Console.WriteLine($"The sum was calculated by: " +
                $"{strategy.GetType().Name}. The result: {result}");
        }

        ICalculateSumStrategy strategy;
    }
}
