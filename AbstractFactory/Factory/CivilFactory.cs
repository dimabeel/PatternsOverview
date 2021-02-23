using AbstractFactory.Vehicle.Civil;

namespace AbstractFactory.Factory
{
    class CivilFactory : IFactory
    {
        public IShip CreateShip()
        {
            return new CivilShip();
        }

        public ICar CreateCar()
        {
            return new CivilCar();
        }

        public IHelicopter CreateHelicopter()
        {
            return new CivilHelicopter();
        }
    }
}
