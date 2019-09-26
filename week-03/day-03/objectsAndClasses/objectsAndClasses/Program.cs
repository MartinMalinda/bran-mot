using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal cheetah = new Animal();
            Animal turkey = new Animal();
            Animal bear = new Animal();

            Farm myFarm = new Farm(20);

            myFarm.AddAnimal(cheetah);
            myFarm.AddAnimal(turkey);
            myFarm.AddAnimal(bear);

            myFarm.Breed(turkey);

            bear.Eat();
            bear.Eat();

            myFarm.Slaughter();
        }
    }
}
