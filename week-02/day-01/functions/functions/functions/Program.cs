using System;

namespace GreenFox
{
    class Program
    {
        public static string Palindrome(string word)
        {
            string palindrome = "";
            char[] letters = word.ToCharArray();
            char[] mirroredLetters = new char[word.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                mirroredLetters[i] = letters[i];
            }
            Array.Reverse(mirroredLetters);
            foreach (var letter in letters )
            {
                palindrome = palindrome + letter;
            }
            foreach (var letter in mirroredLetters)
            {
                palindrome = palindrome + letter;
            }
            return palindrome;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("56788"));
        }
        //multiply the length by 2
        //initialize the values with one for loop
        //.length - i - 1
        //should only use one for loop

    }
}