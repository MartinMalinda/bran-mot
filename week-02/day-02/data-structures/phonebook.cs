using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        public static string NumberLookup (string name, Dictionary<string, string> phonebook)
        {
            if (phonebook.ContainsKey(name))
            {
                string contactName = phonebook[name];
                return contactName;
            }
            else
            {
                return name + " was not found"; 
            }
        }
        public static string NameLookup (string number, Dictionary<string,string> phonebook)
        {
            string name = "";
            if (phonebook.ContainsValue(number))
            {
                foreach (KeyValuePair <string,string> contact in phonebook)
                {
                    if(contact.Value == number)
                    {
                        name = contact.Key;
                    }
                }
                return name;
            }
            else
            {
                return number + " was not found.";
            }
        }

        static void Main(string[] args)
        {
            //We are going to represent our contacts in a map where the keys are going to be strings and the values are going to be strings as well.
            //Create a map with the following key-value pairs.
            //Name(key)  Phone number(value)
            //William A. Lathan   405 - 709 - 1865
            //John K. Miller  402 - 247 - 8568
            //Hortensia E. Foster 606 - 481 - 6467
            //Amanda D. Newland   319 - 243 - 5613
            //Brooke P. Askew 307 - 687 - 2982
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] names = {"William A. Lathan","John K. Miller", "Hortensia E.Foster","Amanda D. Newland","Brooke P. Askew"};
            string[] numbers = {"405 - 709 - 1865","402 - 247 - 8568","606 - 481 - 6467","319 - 243 - 5613","307 - 687 - 2982"};

            for (int i = 0; i < names.Length; i++)
            {
                phonebook.Add(names[i], numbers[i]);
            }

            //Create an application which solves the following problems.

            //What is John K. Miller's phone number?
            Console.WriteLine(NumberLookup("John K. Miller", phonebook));

            //Whose phone number is 307 - 687 - 2982 ?
            Console.WriteLine(NameLookup("307 - 687 - 2982", phonebook));
            //Do we know Chris E.Myers' phone number?
            Console.WriteLine(NumberLookup("Chris E. Myers", phonebook));
    }
}
