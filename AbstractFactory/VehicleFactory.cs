using System;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    public static class VehicleFactory
    {
        public static IFactory GetFactory(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Civil:
                    return new CivilFactory();

                case VehicleType.Millitary:
                    return new MillitaryFactory();

                default:
                    throw new Exception("Unknown factory");
            }
        }

        public enum VehicleType
        {
            Civil,
            Millitary
        }
    }
}
