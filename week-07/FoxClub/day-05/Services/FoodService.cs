using System;
using System.Collections.Generic;
using day05.Interfaces;

namespace day05.Services
{
    public class FoodService : IFood
    {
        public List<string> AllFoods { get; private set; }
        public List<string> AllDrinks { get; private set; }

        public FoodService()
        {
            AllDrinks = new List<string>()
            {
                "Lemonade","Coca Cola", "Alcohol", "Piss"
            };
            AllFoods = new List<string>()
            {
                "Pizza", "Donuts", "Spaghetti"
            };
        }

        public void AddFood(string food)
        {
            throw new NotImplementedException();
        }

        public void RemoveFood(string food)
        {
            throw new NotImplementedException();
        }
    }
}
