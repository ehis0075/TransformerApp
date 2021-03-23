using System;

namespace Transformer
{
    interface Vehicle
    {
        int Wheels { get; } 

        int MaxSpeed { get; }   

         void Run();
           
    }
}