using System;
namespace FlyingVehicles
{
    public class Helicopter : Vehicle, IFlyable
    {
        public Helicopter(string name)
        {
            this.Name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} is flying!");
        }

        public void Land()
        {
            Console.WriteLine($"The {Name} has landed!");
        }

        public void TakeOff()
        {
            Console.WriteLine($"The {Name} has taken off!");
        }
    }
}
