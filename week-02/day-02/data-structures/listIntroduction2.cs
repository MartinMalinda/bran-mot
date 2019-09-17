using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list('List A') which contains the following values
            //BM: 'List A' is a bad way to name the list. changing to 'listA'
            //Apple, Avocado, Blueberries, Durian, Lychee
            List<string> listA = new List<string>();
            string[] fruits = { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            foreach (var fruit in fruits)
            {
                listA.Add(fruit);
            }
            //Create a new list('List B') with the values of List A
            List<string> listB = new List<string>();
            foreach (var listItem in listA)
            {
                listB.Add(listItem);
            }

            //Print out whether List A contains Durian or not
            if (listA.Contains("Durian"))
            {
                Console.WriteLine("The list contains Durian");
            }
            else
            {
                Console.WriteLine("Durian was not found");
            }

            //Remove Durian from List B
            listB.Remove("Durian");

            //Add Kiwifruit to List A after the 4th element
            listA.Insert(4, "Kiwifruit");

            //Compare the size of List A and List B
            if (listA.Count > listB.Count)
            {
                Console.WriteLine("List A is larger than List B");
            }
            else if (listA.Count == listB.Count)
            {
                Console.WriteLine("The lists are equal in size");
            }
            else
            {
                Console.WriteLine("List B is larger than List A");
            }
            //Get the index of Avocado from List A
            Console.WriteLine(listA.IndexOf("Avocado"));

            //Get the index of Durian from List B
            Console.WriteLine(listB.IndexOf("Durian"));

            //Add Passion Fruit and Pomelo to List B in a single statement
            listB.AddRange(new string[] { "Passion Fruit", "Pomelo" });

            //Print out the 3rd element from List A
            Console.WriteLine(listA[2]);
        }
    }
}
