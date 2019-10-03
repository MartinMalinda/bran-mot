using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AbstractsAndInterfaces
{
    public class Fleet 
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public void PrintFleet()
        {
            int counter = 1;
            foreach (var thing in things)
            {
                if (thing.GetComplete())
                {
                    Console.Write($"{counter}. [x] ");
                }
                else
                {
                    Console.Write($"{counter}. [ ] ");
                }
                Console.Write(thing.GetName());
                Console.WriteLine();
                counter++;
            }
        }

        
    }
}