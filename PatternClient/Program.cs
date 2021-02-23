using System;

namespace PatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please, choose your pattern:");
            Console.WriteLine("1. Abstract factory");
            int.TryParse(Console.ReadLine(), out int patternNum);

            switch(patternNum)
            {
                case 1:
                    var factoryTest = new AbstractFactoryTest();
                    factoryTest.Work();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }

    }
}
