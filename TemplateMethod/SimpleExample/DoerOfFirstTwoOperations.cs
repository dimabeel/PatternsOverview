using System;

namespace TemplateMethod
{
    public class DoerOfFirstTwoOperations : BaseAlgorithm
    {
        protected override void DoOperation1()
        {
            Console.WriteLine("Doing operation 1");
        }

        protected override void DoOperation2()
        {
            Console.WriteLine("Doing operation 2");
        }
    }
}
