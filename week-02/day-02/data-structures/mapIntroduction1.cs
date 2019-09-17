using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to play with maps.Feel free to use the built-in methods where possible.
            //Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> map = new Dictionary<int, char>();

            //Print out whether the map is empty or not
            if (map.Count > 0) {
                Console.WriteLine("The dictionary is not empty");
            }
            else
            {
                Console.WriteLine("The dictionary is empty.");
            }
            //Add the following key - value pairs to the map
            //Key Value
            //97  a
            //98  b
            //99  c
            //65  A
            //66  B
            //67  C
            int[] keys = { 97, 98, 99, 65, 66, 67 };
            char[] values = { 'a', 'b', 'c', 'A', 'B', 'C' };

            for (int i = 0; i < keys.Length; i++)
            {
                map.Add(keys[i], values[i]);
            }

            //Print all the keys
            var mapKeys = map.Keys;
            foreach (var key in mapKeys)
            {
                Console.WriteLine(key);
            }

            //Print all the values
            var mapValues = map.Values;
            foreach (var value in mapValues)
            {
                Console.WriteLine(value);
            }

            //Add value D with the key 68
            map.Add(68, 'D');

            //Print how many key-value pairs are in the map
            Console.WriteLine(map.Count);

            //Print the value that is associated with key 99
            Console.WriteLine(map[99]);

            //Remove the key - value pair where with key 97
            map.Remove(97);

            //Print whether there is an associated value with key 100 or not
            if (map.TryGetValue(100, out char exists))
            {
                Console.WriteLine("For key 100, value = {0}.", exists);
            }
            else
            {
                Console.WriteLine("Key 100 is not found.");
            }

            //Remove all the key-value pairs
            map.Clear();
        }
    }
}
