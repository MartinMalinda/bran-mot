using System;
using System.Collections.Generic;

namespace Testing
{
    //Write a function, that takes two strings and returns a boolean value based on if the two strings are Anagramms or not.
    public class AnagramChecker
    {
        public AnagramChecker() { }

        public bool Anagram(string string1, string string2)
        {
            char[] chars1 = string1.ToCharArray();
            char[] chars2 = string2.ToCharArray();
            Array.Sort(chars1);
            Array.Sort(chars2);

            if (chars1.Length != chars2.Length)
            {
                return false;
            }
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //char[] charsOne = { 'd', 'o', 'g' };
            //char[] charsTwo = { 'g', 'o', 'd' };
            //Array.Sort(charsTwo);
            //Array.Sort(charsOne);


        }
    }
}

