using System;
using System.Text;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        public static string OnTheList(string item, List<string> listToCheck)
        {
            if (listToCheck.Contains(item))
            {
                return item + " is on the list.";

            }
            else
            {
                return item + " is not on the list.";
            }
        }

        static void Main(string[] args)
        {
            //Create a list with the following items.
            //Eggs, milk, fish, apples, bread and chicken
            //Create an application which solves the following problems.
            //Do we have milk on the list?
            //Do we have bananas on the list?

            List<string> shoppingList = new List<string>(0);

            shoppingList.AddRange(new string[] { "Eggs", "milk", "fish", "apples", "bread", "chicken" });

            Console.WriteLine(OnTheList("milk", shoppingList));
            Console.WriteLine(OnTheList("bananas", shoppingList));
        }

    }
}
