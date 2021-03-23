using System;

namespace Transformer
{
    class Car : Vehicle
    {
         int wheels = 4;
         int maxSpeed = 350;

        int Vehicle.Wheels 
        {
            get
            {
                return wheels;
            }
        } 

        int Vehicle.MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
        } 

         void Vehicle.Run()
         {
             System.Console.WriteLine("When transformer is on land wheels = {0} - maxSpeed = {1} ", wheels, maxSpeed);
         }     
    }
}