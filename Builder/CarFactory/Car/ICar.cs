namespace Builder.CarFactory.Car
{
    public interface ICar
    {
        WheelsType WheelsType { get; set; }

        EngineType EngineType { get; set; }

        BodyType BodyType { get; set; }

        InteriorType InteriorType { get; set; }

        string CarDescription();
    }

    public enum WheelsType
    {
        Cheap,
        Expensive
    }

    public enum EngineType
    {
        Cheap,
        Expensive
    }

    public enum BodyType
    {
        Cheap,
        Expensive
    }

    public enum InteriorType
    {
        Cheap,
        Expensive
    }
}
