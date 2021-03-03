using Builder.CarFactory.Car;

namespace Builder.CarFactory.CarBuilder
{
    public class ExpensiveCarBuilder : ICarBuilder
    {
        public ExpensiveCarBuilder()
        {
            car = new Car.Car();
        }

        public void Reset()
        {
            car = new Car.Car();
        }
 
        public void CreateBody()
        {
            car.BodyType = BodyType.Expensive;
        }

        public void CreateInterior()
        {
            car.InteriorType = InteriorType.Expensive;
        }

        public void CreateEngine()
        {
            car.EngineType = EngineType.Expensive;
        }

        public void CreateWheels()
        {
            car.WheelsType = WheelsType.Expensive;
        }

        public ICar GetProduct()
        {
            return car;
        }

        ICar car;
    }
}
