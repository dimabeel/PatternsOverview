namespace AbstractFactory.Factory
{
    public interface IFactory
    {
        public ICar CreateCar();

        public IHelicopter CreateHelicopter();

        public IShip CreateShip();
    }
}
