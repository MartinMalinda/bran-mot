using System;
namespace Zoo
{
    //Most of the Reptiles WantChild() from an egg too, so if we exclude some of them(i.e.frogs) from our zoo,
    //it is common with Birds.Write down 2 options at least that can solve this thing.
    // TWO WAYS TO OVERRIDE THE NATURAL BIRTH PROCESS FOR THAT SPECIFIC TYPE OF ANIMAL
    public class Reptile : Animal
    {
        public string BirthMethod = "eggs";

        public Reptile()
        {
        }

        public Reptile(string name)
        {
            this.Name = name;
        }

        public override string WantChild()
        {
            return $"I want a child from my {BirthMethod}";
        }
    }
}
