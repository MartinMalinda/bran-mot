using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a map where the keys are strings and the values are strings with the following initial values
            //Key Value
            //978 - 1 - 60309 - 452 - 8   A Letter to Jo
            //978 - 1 - 60309 - 459 - 7   Lupus
            //978 - 1 - 60309 - 444 - 3   Red Panda and Moon Bear
            //978 - 1 - 60309 - 461 - 0   The Lab
            Dictionary<string, string> library = new Dictionary<string, string>();
            string[] isbn = { "978 - 1 - 60309 - 452 - 8", "978 - 1 - 60309 - 459 - 7", "978 - 1 - 60309 - 444 - 3", "978 - 1 - 60309 - 461 - 0" };
            string[] title = { "A Letter to Jo", "Lupus", "Red Panda and Moon Bear", "The Lab" };

            for (int i = 0; i < isbn.Length; i++)
            {
                library.Add(isbn[i], title[i]);
            }

            //Print all the key-value pairs in the following format
            //A Letter to Jo(ISBN: 978 - 1 - 60309 - 452 - 8)
            //Lupus(ISBN: 978 - 1 - 60309 - 459 - 7)
            //Red Panda and Moon Bear(ISBN: 978 - 1 - 60309 - 444 - 3)
            //The Lab(ISBN: 978 - 1 - 60309 - 461 - 0)

            foreach (KeyValuePair<string, string> book in library)
            {
                Console.WriteLine("{0} (ISBN: {1})", book.Value, book.Key);
            }

            //Remove the key - value pair with key 978 - 1 - 60309 - 444 - 3
            library.Remove("978 - 1 - 60309 - 444 - 3");

            //Remove the key - value pair with value The Lab
            string keyToDelete = "";
            foreach (KeyValuePair<string, string> book in library)
            {
                if (book.Value.Equals("The Lab")) {
                    keyToDelete = book.Key;
                }
            }
            library.Remove(keyToDelete);

            //  Add the following key - value pairs to the map
            //Key Value
            //978 - 1 - 60309 - 450 - 4   They Called Us Enemy
            //978 - 1 - 60309 - 453 - 5   Why Did We Trust Him?
            string[] newIsbn = { "978 - 1 - 60309 - 450 - 4", "978 - 1 - 60309 - 453 - 5" };
            string[] newTitle = { "They Called Us Enemy", "Why Did We Trust Him?" };

            for (int i = 0; i < newIsbn.Length; i++)
            {
                library.Add(newIsbn[i], newTitle[i]);
            }

            //Print whether there is an associated value with key 478 - 0 - 61159 - 424 - 8 or not
            string keyToFind = "478 - 0 - 61159 - 424 - 8";
            if (library.ContainsKey(keyToFind)){
                Console.WriteLine("{0} was found with the value of {1}", keyToFind, library[keyToFind]);
            }
            else
            {
                Console.WriteLine("There is no associated value for {0}", keyToFind);
            }

            //Print the value associated with key 978 - 1 - 60309 - 453 - 5
            Console.WriteLine(library["978 - 1 - 60309 - 453 - 5"]);
        }
    }
}
