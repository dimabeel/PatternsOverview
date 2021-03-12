using System;

namespace TemplateMethod
{
    public class DoerOfSecondOperation : BaseAlgorithm
    {
        protected override void DoOperation2()
        {
            Console.WriteLine("Doing operation 2");
        }
    }
}
