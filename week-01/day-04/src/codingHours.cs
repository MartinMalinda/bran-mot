using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int semesterLength = 17;
            int averageWeeklyCodingHours = 52;
            int averageWeeklyHours = 40;
            double percentOfWorkingTime = (double)(averageWeeklyCodingHours * semesterLength) / (averageWeeklyHours * semesterLength)*100;

            Console.WriteLine("The average attendee spends " + averageWeeklyCodingHours * semesterLength + " hours coding");
            Console.WriteLine("That means each attendee spends " + percentOfWorkingTime + "% of their time coding");
        }
    }
}