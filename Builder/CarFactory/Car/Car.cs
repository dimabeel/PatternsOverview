namespace Builder.CarFactory.Car
{
    class Car : ICar
    {
        public BodyType BodyType { get; set; }

        public EngineType EngineType { get; set; }

        public InteriorType InteriorType { get; set; }

        public WheelsType WheelsType { get; set; }

        public string CarDescription()
        {
            return $"Body type: {BodyType}\n" +
                $"Engine type: {EngineType}\n" +
                $"Interior type: {InteriorType}\n" +
                $"Wheels type: {WheelsType}";
        }

        // Other behavior...
    }
}
