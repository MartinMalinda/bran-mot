using System;

namespace objectsAndClasses //which part of the project am i in? this is to avoid conflicts.
{
    //Public: access class modifier. Says whether or not others can access it.
    public class Person
    {
        //fields - variable inside my class, not changeable
        //Should be lowercase
        //public string name = "John";


        //properties - more common to use these, accessible from outside the class
        //Should be sentence case
        public string Name { get;  set; }
        public int Age { get; set; }
        public double Height { get; set; } = 100; //default value
        public double Weight { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }

        //constructor, allows you to use the blueprint

        public Person() { }
        public Person(string Name, int Age, double Height, double Weight, string HairColor, string EyeColor)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;
            this.HairColor = HairColor;
            this.EyeColor = EyeColor;
        }

        

        //methods (actions) that are specific to this class
        public void Talking()
        {
            Console.WriteLine($"{Name} is talking");
        }
        public void Walking()
        {
            Console.WriteLine($"{Name} is walking");
        }
        
    }

    
}