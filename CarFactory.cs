using System;

namespace FactoryPattern
{
    class CarFactory
    {        
        public Car GetCar(string type)
        {
            switch(type)
            {
                case "Electric" :
                    return new ElectricCar();
                                        
                case "Petrol" :
                    return new PetrolCar();
                                        
                case "Diesel" :
                    return new DieselCar();
                    
                default:
                    return null;
            }
        }

    }
}