using System;
namespace objectsAndClasses
{
    public class Animal
    {
        //Create an Animal class
        //Every animal has a hunger value, which is a whole number
        //Every animal has a thirst value, which is a whole number
        //when creating a new animal object these values are created with the default 50 value
        //Every animal can Eat() which decreases their hunger by one
        //Every animal can Drink() which decreases their thirst by one
        //Every animal can Play() which increases both by one

        public int Hunger { get; set; } = 50;
        public int Thirst { get; set; } = 50;

        public Animal()
        {
        }

        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}
