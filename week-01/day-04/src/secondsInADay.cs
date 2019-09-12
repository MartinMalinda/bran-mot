using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            //int maxHours = 23;
            //int maxMinutes = 59;
            //int maxSeconds = 59;

            int remainingHours = 23 - currentHours;
            int remainingMinutes = 59 - currentMinutes;
            int remainingSeconds = 59 - currentSeconds;

            Console.WriteLine("There are " + remainingHours + " hours, "+remainingMinutes + " minutes, and " + remainingSeconds + " seconds remaining today.");
        }
    }
}