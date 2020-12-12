using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory fact = new CarFactory();
            Car c = fact.GetCar("Electric");
            Car c1 = fact.GetCar("Diesel");
            Car c2 = fact.GetCar("Petrol");
        }
    }
}
