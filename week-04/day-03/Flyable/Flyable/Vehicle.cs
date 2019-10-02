using System;
namespace FlyingVehicles    
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }

        public Vehicle()
        {
        }
    }
}
