using System;
using System.Collections.Generic;
using System.Text;
using Builder.CarFactory.Car;

namespace Builder.CarFactory.CarBuilder
{
    public interface ICarBuilder
    {
        void CreateWheels();

        void CreateEngine();

        void CreateBody();

        void CreateInterior();

        void Reset();

        ICar GetProduct();
    }
}
