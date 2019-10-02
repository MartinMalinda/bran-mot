using System;
namespace Zoo
{
    //Let's think about the species of animals Mammals, Reptiles, Birdss etc, we call them as groups now.
    //In the group we need to define group specified fields and methods. For example every Bird WantChild() from an egg,
    //doesn't matter if it is a penguin or parrot or ostrich. Write down at least 2 of field and/or method what is common in each group above!
    public class Mammal : Animal
    {
        public string BirthMethod = "uterus";


        public Mammal()
        {
        }

        public Mammal(string name)
        {
            this.Name = name;
        }

        public override string WantChild()
        {
            return $"I want a child from my {BirthMethod}";
        }
    }
}
