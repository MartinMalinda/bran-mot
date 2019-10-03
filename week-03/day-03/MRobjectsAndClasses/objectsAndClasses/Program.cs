using System;

namespace objectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes are blueprints
            Person personOne = new Person(); //instance of person class
            personOne.Name = "James";
            personOne.EyeColor = "purple";

            Person personTwo = new Person("Brandon", 34, 150.0, 150.0, "Black", "Brown");

            Console.WriteLine(personTwo.Name);
            personTwo.Walking();

            //call static class
            Hair.Cut();
        }
    }
    //static classes have blueprints that cant be used. You cant use this to create new objects
    static class Hair
    {
        static public void Cut()
        {
            Console.WriteLine("Cut my hair!!");
        }
    }
}
