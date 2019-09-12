using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            Console.WriteLine("We're having a party. How many girls are coming?");
            int girls = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many boys are coming?");
            int boys = int.Parse(Console.ReadLine());
            int totalNumberOfGuests = boys + girls;
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            if (boys == girls && totalNumberOfGuests > 20)
            {
                Console.WriteLine("The party is excellent!");
                // It should print: Sausage party
                // If no girls are coming, regardless the count of the people;
            }
            else if (girls == 0)
            {
                Console.WriteLine("Sausage Party");
                // It should print: Quite cool party!
                // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            }
            else if (girls != boys && totalNumberOfGuests > 20)
            {
                Console.WriteLine("Quite cool party!");
                // It should print: Average party...
                // If there are less people coming than 20
            }
            else if (totalNumberOfGuests < 20){
                Console.WriteLine("Average party...");
             
            }

        }
    }
}