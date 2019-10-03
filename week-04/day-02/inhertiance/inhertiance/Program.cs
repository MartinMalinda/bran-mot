using System;
using System.Collections.Generic;

namespace inhertiance 
{
    public class Garden
    {
        public List<Plant> garden;

        public Garden()
        {
            garden = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            garden.Add(plant);
        }

        public void GardenStatus()
        {
            foreach (var plant in garden)
            {
                if (plant.NeedsWater())
                {
                    Console.WriteLine($"The {plant.Color} {plant.GetType()} needs water");
                }
                else
                {
                    Console.WriteLine($"The { plant.Color}{ plant.GetType()} doesn't need water");
                }
            }
            Console.WriteLine();
        }
        public void WaterGarden(int waterAmount)
        {
            int plantsToWater = 0;
            foreach (var plant in garden)
            {
                if (plant.NeedsWater())
                {
                    plantsToWater++;
                }
            }
            foreach (var plant in garden)
            {
                if (plant.NeedsWater())
                {
                    plant.WaterPlant(waterAmount / plantsToWater);
                }
            }
            Console.WriteLine($"Watering with {waterAmount}");
            GardenStatus();
        }
    }
    public class Plant
    {
        public double WaterLevel { get; set; } = 0;
        public int WaterThreshold { get; set; }
        public string Color { get; set; }
        public double Absoprtion { get; set; }

        public Plant()
        {

        }
        public bool NeedsWater()
        {
            if (WaterLevel < WaterThreshold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void WaterPlant(double waterAmount)
        {
            this.WaterLevel += (waterAmount*Absoprtion);
        }
    }
    public class Flower : Plant
    {
       public Flower(string color)
        {
            WaterThreshold = 5;
            this.Color = color;
            Absoprtion = .75;
        }
        
    }
    public class Tree : Plant
    {
        public Tree(string color)
        {
            WaterThreshold = 10;
            this.Color = color;
            Absoprtion = 0.4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            myGarden.AddPlant(new Flower("blue"));
            myGarden.AddPlant(new Flower("yellow"));
            myGarden.AddPlant(new Tree("purple"));
            myGarden.AddPlant(new Tree("orange"));

            myGarden.GardenStatus();

            myGarden.WaterGarden(40);
            myGarden.WaterGarden(70);
        }
    }
}
