using System;

namespace Testing
{
    //Create a class, with one method(eg. public string GetApple()) that returns a string (eg. "apple")
    //Create a test for that.
    //Create an xUnit project
    //Add a new Test case in it

    public class Apple
    {
        public string Name { get; set; }

        public Apple(string name)
        {
            Name = name;
        }

        public string GetApple()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
