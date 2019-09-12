using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
     
            Console.WriteLine("Hello, Imperialist! How many miles did you travel to get here?");
            string distanceInMiles = Console.ReadLine();
            double distanceInKilometers = Convert.ToDouble(distanceInMiles) * 1.60934;
            Console.WriteLine("That's " + distanceInKilometers + "kM! Welcome to the rest of the world!" );
        }
    }
}