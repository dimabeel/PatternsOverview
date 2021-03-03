using System;

namespace Builder.CarFactory.CarBuilder
{
    public interface ICarDirector
    {
        // Or use BuildCar method with type of car argument
        void CreateCar();

        void ChangeBuilder(ICarBuilder carBuilder);
    }
}
