using System;

namespace GreenFox
{
    class Program
    {
        public static string Anagram(string wordOne, string wordTwo)
        {
            string anagram = "";
            char[] firstWord = wordOne.ToCharArray();
            char[] secondWord = wordTwo.ToCharArray();
            Array.Sort(firstWord);
            Array.Sort(secondWord);
            if (firstWord.Length != secondWord.Length)
            {
                anagram = "This is not an anagram";
            }
            else
            {
                anagram = "This is an anagram!";
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (firstWord[i] != secondWord[i])
                    {
                        anagram = "This is not an anagram";
                        break;
                    }
                }
            }
            return anagram;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Anagram("green", "fox"));
        }
    }
}