using Car.Entities;
using Car.Enum;
using System;

namespace Car
{


    class Program
    {
        static void Main(string[] args)
        {
            var electricCar = new ElectricCar()
            {
                Brand = "bmw",
                Model = 2001,
                Door = 5,
                TopSpeed = 150,
                Consumption = Consumption.Medium
            };

            electricCar.PrintInfo();
            electricCar.Drive(200);
            electricCar.Recharge(300);

            var fuelCar = new FuelCar()
            {
                Brand = "Open",
                Model = 2005,
                Door = 4,
                TopSpeed = 200,
                Consumption = Consumption.High
            };

            fuelCar.PrintInfo();
            fuelCar.Drive(300);
            fuelCar.Refuel(40);




        }
    }
}
