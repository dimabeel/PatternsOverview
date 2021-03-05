using System;
using dIterator = Iterator.DefaultEnumerator;
using cIterator = Iterator.CustomEnumerator;
using eIterator = Iterator.EnumerableIterator;

namespace PatternClient
{
    public class IteratorTest
    {
        public void Work()
        {
            UseDefaultCSharpIterator();
            Console.WriteLine();
            UseCustomIterator();
            Console.WriteLine();
            UseSomethingLikeIterator();
        }

        private void UseDefaultCSharpIterator()
        {
            dIterator.ICar[] carsForGagarage = new dIterator.Car[]
            {
                new dIterator.Car() {Name = "VW Golf", YearOfProduction = 2010 },
                new dIterator.Car() {Name = "Ford Fusion", YearOfProduction = 2005 },
                new dIterator.Car() {Name = "Tesla Flying Truck", YearOfProduction = 2100 },
                new dIterator.Car() {Name = "Ford Mondeo", YearOfProduction = 1999 },
                new dIterator.Car() {Name = "Mercedes W123", YearOfProduction = 1984 },
            };

            dIterator.IGarage garage = new dIterator.Garage(carsForGagarage);
            foreach (dIterator.ICar car in garage)
            {
                Console.WriteLine($"Name:{car.Name}, Year:{car.YearOfProduction}");
            }

            Console.WriteLine();

            //Or another way
            var garageEnumerator = garage.GetEnumerator();
            while (garageEnumerator.MoveNext())
            {
                var current = (dIterator.ICar)garageEnumerator.Current;
                Console.WriteLine($"Name:{current.Name}, Year:{current.YearOfProduction}");
            }
        }

        private void UseCustomIterator()
        {
            cIterator.ICar[] vwCars = new cIterator.Car[]
            {
                new cIterator.Car { Name = "VW Polo", YearOfProduction = 2013 },
                new cIterator.Car { Name = "VW Tiguan", YearOfProduction = 2015 },
            };

            cIterator.ICar[] skodaCars = new cIterator.Car[]
            {
                new cIterator.Car { Name = "Skoda Fabia", YearOfProduction = 2018 },
                new cIterator.Car { Name = "Skoda Kodiaq", YearOfProduction = 2017 },
            };

            cIterator.IGarage vwGarage = new cIterator.Garage(vwCars);
            vwGarage.Name = "Volkswagen Garage";
            cIterator.IGarage skodaGarage = new cIterator.Garage(skodaCars);
            skodaGarage.Name = "SKoda Garage";

            cIterator.IGarage[] garages = new cIterator.IGarage[]
            {
                vwGarage,
                skodaGarage
            };
            cIterator.GarageCooperative garageCooperative =
                new cIterator.GarageCooperative(garages);

            var garageIterator = garageCooperative.CreateIterator();
            while(garageIterator.HasMore())
            {
                var garage = garageIterator.GetNext();
                Console.WriteLine(garage.Name);
                var carsIterator = garage.CreateIterator();
                while(carsIterator.HasMore())
                {
                    var car = carsIterator.GetNext();
                    Console.WriteLine($"Car info: {car.Name}, {car.YearOfProduction}");
                }
            }
        }

        private void UseSomethingLikeIterator()
        {
            eIterator.ICar[] vwCars = new eIterator.Car[]
            {
                new eIterator.Car { Name = "VW Polo", YearOfProduction = 2013 },
                new eIterator.Car { Name = "VW Tiguan", YearOfProduction = 2015 },
            };

            eIterator.ICar[] skodaCars = new eIterator.Car[]
            {
                new eIterator.Car { Name = "Skoda Fabia", YearOfProduction = 2018 },
                new eIterator.Car { Name = "Skoda Kodiaq", YearOfProduction = 2017 },
            };

            eIterator.IGarage vwGarage = new eIterator.Garage(vwCars);
            vwGarage.Name = "Volkswagen Garage";
            eIterator.IGarage skodaGarage = new eIterator.Garage(skodaCars);
            skodaGarage.Name = "SKoda Garage";

            eIterator.IGarage[] garages = new eIterator.IGarage[]
            {
                vwGarage,
                skodaGarage
            };
            eIterator.IGarageCooperative garageCooperative =
                new eIterator.GarageCooperative(garages);

            foreach(var garageItem in garageCooperative
                .GetItems(garageCooperative as eIterator.IGarageNode))
            {
                Console.WriteLine(garageItem.ToString());
            }
        }
    }
}
