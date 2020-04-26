using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Entities
{
    class FuelCar: Car
    {
        public int FuelCapacity=80;
        public int CurrentFuel;



        public int Drive(int distance)
        {
            var drive = distance * (int)Consumption / 10;
            return drive;
        }

        //Refuel(method that fills the tank with fuel, should take fuel as parameter and shouldn't exceed fuel capacity)
        public int Refuel(int fuel)
        {
            if (fuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
            }
            else
            {
                Console.WriteLine($"Tank has been fueled with {fuel} l.");
            }

            return fuel;
        }
    }
}

