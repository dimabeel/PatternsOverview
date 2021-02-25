using System;

namespace PatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please, choose your pattern:");
            Console.WriteLine("1. Abstract factory");
            Console.WriteLine("2. Factory method");
            Console.WriteLine("3. Adapter");
            int.TryParse(Console.ReadLine(), out int patternNum);

            switch(patternNum)
            {
                case 1:
                    var factoryTest = new AbstractFactoryTest();
                    factoryTest.Work();
                    break;

                case 2:
                    var factoryMethodTest = new FactoryMethodTest();
                    factoryMethodTest.Work();
                    break;

                case 3:
                    var adapterTest = new AdapterTest();
                    adapterTest.Work();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }

    }
}
