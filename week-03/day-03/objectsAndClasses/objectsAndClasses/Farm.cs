using System;
using System.Collections.Generic;
namespace objectsAndClasses
{
    //Create a Farm class
    //it has list of Animals
    //it has slots which defines the number of free places for animals
    //Breed() -> creates a new animal if there's place for it
    //Slaughter() -> removes the least hungry animal

    public class Farm
    {
        public List<Animal> animalsOnTheFarm;
        public int spacesOnTheFarm { get; set; }
        private string fullMessage = "The farm is too full to add another animal";
        private int spacesLeft { get; set; }

        public Farm(int spaces)
        {
            animalsOnTheFarm = new List<Animal>();
            animalsOnTheFarm.Capacity = spaces;
            spacesLeft = animalsOnTheFarm.Capacity - animalsOnTheFarm.Count;

        }

        public void AddAnimal(Animal animalToAdd)
        {
            if (animalsOnTheFarm.Count < animalsOnTheFarm.Capacity)
            {
                animalsOnTheFarm.Add(animalToAdd);
            }
            else
            {
                Console.WriteLine(fullMessage);
            }
            
        }

        public void AddAnimal(Animal[] animals)
        {
            if (this.spacesLeft > animals.Length)
            {
                foreach (Animal animal in animals)
                {
                    animalsOnTheFarm.Add(animal);
                }
            }
            else
            {
                Console.WriteLine(fullMessage);
            }   
        }

        public void Breed(Animal animal)
        {
            if (spacesLeft > 0)
            {
                animalsOnTheFarm.Add(animal);
                Console.WriteLine($"A new animal has been bred! There are now {animalsOnTheFarm.Count} animals on your farm!");
            }
            else
            {
                Console.WriteLine(fullMessage);
            }
        }

        public void Slaughter()
        {
            int animalToSlaughterIndex = 0;
            int currentAnimalHunger = 100;
            for (int i = 0; i < animalsOnTheFarm.Count -1; i++)
            {
                if (animalsOnTheFarm[i].Hunger < currentAnimalHunger)
                {
                    currentAnimalHunger = animalsOnTheFarm[i].Hunger;
                    animalToSlaughterIndex = i;
                }
            }
            animalsOnTheFarm.RemoveAt(animalToSlaughterIndex);
            Console.WriteLine($"One animal was slaughtered. There are now {animalsOnTheFarm.Count} Left");
        }
    }
}
