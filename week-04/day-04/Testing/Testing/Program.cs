using System;
using System.Collections.Generic;

namespace Testing
{
    public class CountLetters
    {
        public static Dictionary<char, int> LetterCount (string stringToParse)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            char[] charactersInString = stringToParse.ToCharArray();

            foreach (var character in charactersInString)
            {
                if (letterCount.ContainsKey(character))
                {
                    letterCount[character]+= 1;
                }
                else
                {
                    letterCount.Add(character, 1);
                }
            }
            return letterCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

