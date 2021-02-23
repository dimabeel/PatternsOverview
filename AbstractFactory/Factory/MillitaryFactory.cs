using AbstractFactory.Vehicle.Millitary;

namespace AbstractFactory.Factory
{
    class MillitaryFactory : IFactory
    {
        public IShip CreateShip()
        {
            return new MillitaryShip();
        }

        public ICar CreateCar()
        {
            return new MillitaryCar();
        }

        public IHelicopter CreateHelicopter()
        {
            return new MillitaryHelicopter();
        }
    }
}
