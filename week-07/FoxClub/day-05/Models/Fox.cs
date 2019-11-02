using System;
using System.Collections.Generic;
using day05.Interfaces;

namespace day05.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; private set; }
        public List<string> Foods { get; private set; }

        public Fox(string name)
        {
            Name = name;
            Tricks = new List<string>();
            Foods = new List<string>();
        }

        public void AddTrick(string trick)
        {
            Tricks.Add(trick);
        }

        public void AddFood(string food)
        {
            Foods.Add(food);
        }
    }
}
