using System;
using Builder.CarFactory.CarBuilder;
using Builder.TeaFactory;

namespace PatternClient
{
    public class BuilderTest
    {
        public void Work()
        {
            Console.WriteLine("Test car factory with differences properties " +
                "but equal count of properties:");
            ICarBuilder cheapCarBuilder = new CheapCarBuilder();
            ICarDirector carDirector = new CarDirector(cheapCarBuilder);
            carDirector.CreateCar();

            Console.WriteLine(cheapCarBuilder.GetProduct().CarDescription());

            Console.WriteLine();

            ICarBuilder expensiveCarBuilder = new ExpensiveCarBuilder();
            carDirector.ChangeBuilder(expensiveCarBuilder);
            carDirector.CreateCar();
            Console.WriteLine(expensiveCarBuilder.GetProduct().CarDescription());

            Console.WriteLine();

            ITeaBuilder usualTeaBuilder = new UsualTeaBulder();
            ITeaDirector teaMaker = new TeaDirector(usualTeaBuilder);
            teaMaker.MakeTea();
            Console.WriteLine("Usual tea");
            Console.WriteLine(usualTeaBuilder.GetTea().DescribeTea());

            ITeaBuilder tastyTeaBuilder = new TastyTeaBuilder();
            teaMaker.ChangeBuilder(tastyTeaBuilder);
            teaMaker.MakeTea();
            Console.WriteLine("Tasty tea");
            Console.WriteLine(tastyTeaBuilder.GetTea().DescribeTea());
        }
    }
}
