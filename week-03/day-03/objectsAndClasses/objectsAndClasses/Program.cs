using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            string[] thingsToAdd = { "Get milk", "Remove the obstacles", "Stand up", "Eat lunch" };
            Thing[] thingsForFleet = new Thing[thingsToAdd.Length];

            for (int i = 0; i < thingsToAdd.Length; i++)
            {
                thingsForFleet[i] = new Thing(thingsToAdd[i]);
            }
            thingsForFleet[2].Complete();
            thingsForFleet[3].Complete();

            foreach (var thing in thingsForFleet)
            {
                fleet.Add(thing);
            }

            fleet.PrintFleet();
            
        }
    
    }
}
