using System;
using TemplateMethod;

namespace PatternClient
{
    public class TemplateMethodTest
    {
        public void Work()
        {
            BaseAlgorithm alg = new DoerOfAllOperations();
            alg.ProcessInformation();
            Console.WriteLine();

            alg = new DoerOfFirstTwoOperations();
            alg.ProcessInformation();
            Console.WriteLine();

            alg = new DoerOfSecondOperation();
            alg.ProcessInformation();
        }
    }
}