using Builder.CarFactory.Car;

namespace Builder.CarFactory.CarBuilder
{
    public class CheapCarBuilder : ICarBuilder
    {
        public CheapCarBuilder()
        {
            car = new Car.Car();
        }

        public void Reset()
        {
            car = new Car.Car();
        }
 
        public void CreateBody()
        {
            car.BodyType = BodyType.Cheap;
        }

        public void CreateInterior()
        {
            car.InteriorType = InteriorType.Cheap;
        }

        public void CreateEngine()
        {
            car.EngineType = EngineType.Cheap;
        }

        public void CreateWheels()
        {
            car.WheelsType = WheelsType.Cheap;
        }

        public ICar GetProduct()
        {
            return car;
        }

        ICar car;
    }
}
