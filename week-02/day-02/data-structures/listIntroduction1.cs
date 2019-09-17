using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty list which will contain names(strings)
            List<string> names = new List<string>();

            //Print out the number of elements in the list
            Console.WriteLine(names.Count) ;

            //Add William to the list
            names.Add("William");

            //Print out whether the list is empty or not
            if (names.Capacity > 0)
            {
                Console.WriteLine("The list is not empty");
            }

            //Add John to the list
            names.Add("John");

            //Add Amanda to the list
            names.Add("Amanda");

            //Print out the number of elements in the list
            Console.WriteLine(names.Count);

            //Print out the 3rd element
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Iterate through the list and print out each name
            int index = 1;
            foreach (var name in names)
            {
                Console.WriteLine("{0}. {1}", index, name);
                index++;
            }
            //Remove the 2nd element
            names.RemoveAt(1);
            //terate through the list in a reversed order and print out each name
            for (int i = names.Count-1; i >= 0 ; i--)
            {
                Console.WriteLine(names[i]);
            }
            //Remove all elements
            names.Clear();
        }
    }
}
