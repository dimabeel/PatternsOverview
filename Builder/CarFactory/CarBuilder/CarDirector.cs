using Builder.CarFactory.Car;

namespace Builder.CarFactory.CarBuilder
{
    public class CarDirector : ICarDirector
    {
        public CarDirector(ICarBuilder carBuilder)
        {
            builder = carBuilder;
        }

        public void ChangeBuilder(ICarBuilder carBuilder)
        {
            builder = carBuilder;
        }

        public void CreateCar()
        {
            builder.Reset();
            builder.CreateBody();
            builder.CreateEngine();
            builder.CreateInterior();
            builder.CreateWheels();
        }

        ICarBuilder builder;
    }
}
