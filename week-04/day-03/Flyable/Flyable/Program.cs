using System;

namespace FlyingVehicles    
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird robin = new Bird("Robin");

            robin.Fly();
            robin.Land();
            robin.TakeOff();
        }
    }
}
