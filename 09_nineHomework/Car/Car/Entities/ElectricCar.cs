using System;
using Car.Enum;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Car.Entities
{

        class ElectricCar : Car
        {

        
            public int BatteryCapacity = 100;
            public double BatteryUsage;


                public void Recharge(int minutes)
                {

                    var recharge = minutes / 10;
                    if (minutes == 100 * 10)
                    {
                        Console.WriteLine($"Can't charge longer that {minutes} minutes");
                    }
                    else
                    {
                        BatteryCapacity += recharge;
                        Console.WriteLine($"The Battery has been charged for {recharge}%!");
                    }
                }
        }

    }




//Recharge(method that charges the battery of the car, it takes one parameter minutes, 
//10 minutes charges 1 percent of the battery)