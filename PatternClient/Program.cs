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
            Console.WriteLine("4. Facade");
            Console.WriteLine("5. Decorator");
            Console.WriteLine("6. Proxy");
            Console.WriteLine("7. Bridge");
            Console.WriteLine("8. Composite");
            Console.WriteLine("9. Builder");
            Console.WriteLine("10. Iterator");
            Console.WriteLine("11. Observer");
            Console.WriteLine("12. Strategy");
            Console.WriteLine("13. Visitor");
            Console.WriteLine("14. State");
            Console.WriteLine("15. Chain of responsibility");
            Console.WriteLine("16. Template method");
            Console.WriteLine("17. Controller");
            Console.WriteLine("18. Command");
            Console.WriteLine("19. Memento");
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

                case 4:
                    var facadeTest = new FacadeTest();
                    facadeTest.Work();
                    break;

                case 5:
                    var decoratorTest = new DecoratorTest();
                    decoratorTest.Work();
                    break;

                case 6:
                    var proxyTest = new ProxyTest();
                    proxyTest.Work();
                    break;

                case 7:
                    var bridgeTest = new BridgeTest();
                    bridgeTest.Work();
                    break;

                case 8:
                    var compositeTest = new CompositeTest();
                    compositeTest.Work();
                    break;

                case 9:
                    var builderTest = new BuilderTest();
                    builderTest.Work();
                    break;

                case 10:
                    var iteratorTest = new IteratorTest();
                    iteratorTest.Work();
                    break;

                case 11:
                    var observerTest = new ObserverTest();
                    observerTest.Work();
                    break;

                case 12:
                    var strategyTest = new StrategyTest();
                    strategyTest.Work();
                    break;

                case 13:
                    var visitorTest = new VisitorTest();
                    visitorTest.Work();
                    break;

                case 14:
                    var stateTest = new StateTest();
                    stateTest.Work();
                    break;

                case 15:
                    var chainOfResponsibilityTest = new ChainOfResponsibilityTest();
                    chainOfResponsibilityTest.Work();
                    break;

                case 16:
                    var templateMethodTest = new TemplateMethodTest();
                    templateMethodTest.Work();
                    break;

                case 17:
                    var controllerTest = new ControllerTest();
                    controllerTest.Work();
                    break;

                case 18:
                    var commandTest = new CommandTest();
                    commandTest.Work();
                    break;

                case 19:
                    var mementoTest = new MementoTest();
                    mementoTest.Work();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }

    }
}
