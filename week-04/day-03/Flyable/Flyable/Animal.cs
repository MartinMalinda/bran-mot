using System;
namespace FlyingVehicles    
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Poop()
        {
            Console.WriteLine($"The {Name} pooped.");
        }

        public void Eat()
        {
            Console.WriteLine( $"The {Name} ate.");
        }
        public string GetName()
        {
            return Name;
        }

        //it has Greet() and WantChild() methods
        public void Greet()
        {
            Console.WriteLine($"Hi, I'm a {Name}!");
        }

        public abstract string WantChild(); 
    }
}
