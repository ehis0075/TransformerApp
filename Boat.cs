using System;

namespace Transformer
{
    class Boat : Vehicle
    {
         int wheels = 0;
         int maxSpeed = 200;

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
             System.Console.WriteLine("When transformer is on boot wheels = {0} - maxSpeed = {1} ", wheels, maxSpeed);
         }  
    }
}