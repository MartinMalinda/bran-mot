using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Fox
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Color { get; private set; }

        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties: name, type and color.

            //Fill a list with at least 5 foxes, it's up to you how you name/create them.
            List<Fox> myFoxes = new List<Fox>
            {
                new Fox("Joe", "Arctic", "White"),
                new Fox("Harry", "Arctic", "White"),
                new Fox("Martha", "Arctic", "White"),
                new Fox("Jeanie", "Pallida", "Green"),
                new Fox("Angela", "Programmer", "Green")
            };

            //Write a LINQ Expression to find the foxes with green color.
            //Write a LINQ Expression to find the foxes with green color and pallida type.

            var greenFoxes = myFoxes.Where(fox => fox.Color == "Green").Select(fox => fox.Name).ToList();
            var greenPallidaFoxes = myFoxes.Where(fox => fox.Color == "Green" && fox.Type == "Pallida").Select(fox => fox.Name).ToList();
            Console.WriteLine(
                "Green Foxes \n" +
                "===========");
            greenFoxes.ForEach(Console.WriteLine);
            Console.WriteLine(
                "\nGreen Pallida Foxes \n" +
                "===================");
            greenPallidaFoxes.ForEach(Console.WriteLine);
        }
    }
}
