using System;

namespace TemplateMethod
{
    public class DoerOfAllOperations : BaseAlgorithm
    {
        protected override void DoOperation1()
        {
            Console.WriteLine("Doing operation 1");
        }

        protected override void DoOperation2()
        {
            Console.WriteLine("Doing operation 2");
        }

        protected override void DoOperation3()
        {
            Console.WriteLine("Doing operation 3");
        }
    }
}
