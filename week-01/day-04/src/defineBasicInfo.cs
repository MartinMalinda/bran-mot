using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "Brandon";
            int age = 34;
            double height = 1.7;
            bool married = false;

            Console.WriteLine("My name is " + name + ". I am " + age + " years old. I stand " + height + "M tall");
            if (married == true) { 
                Console.WriteLine("I am married");
            }
            else
            {
                Console.WriteLine("I'm single, and ready to mingle");
            }
        }
    }
}