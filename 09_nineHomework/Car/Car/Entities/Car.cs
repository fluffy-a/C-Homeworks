using Car.Enum;
using CarService;
using System;
using System.Collections.Generic;


namespace Car.Entities
{
    public class Car
    {

        public Car()
        {
            
        }

        public string Brand;
        public int Model;
        public int Door;
      
        public Consumption Consumption;
        public EngineType EngineType;
        public int TopSpeed;
        private int ID= IdGenerator.GenerateID();






        public void PrintInfo()
        {
            Console.WriteLine($"The car is {Brand} , model {Model} and has {Door} doors, and max speed is {TopSpeed} km with ID {ID}.");
        }



        public int Drive(int distance)
        {
            var drive = distance * (int)Consumption / 10;
            return drive;
        }

    }



    //BatteryCapacity
    //BatteryUsage(percentage of used battery)
    //Drive - method that takes distance as parameter and calculates how much of the battery has been used
    //(distance* consumption(economic - 1, medium - 2, high - 3) / 10

}






