using System;

namespace Transformer
{
    class Jet : Vehicle
    {
         int wheels = 8;
         int maxSpeed = 900;

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
             System.Console.WriteLine("When transformer is on air wheels = {0} - maxSpeed = {1} ", wheels, maxSpeed);
         }  
    }
}