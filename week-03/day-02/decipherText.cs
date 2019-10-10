using System;
using System.IO;
using System.Collections.Generic;

namespace DecipherText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"./decipherMe.txt");
            Dictionary<char, char> cipher = new Dictionary<char, char>();
            cipher.Add(' ', ' ');
            string alphabet = "abcdefghijklmnopqrstuvwxyz[,-./*+'(!\"";
            for (int i = 1; i < alphabet.Length; i++)
            {
                cipher.Add(alphabet[i], alphabet[i - 1]);
            }

            string decoded = "";

            foreach (var line in fileLines)
            {
                foreach (var character in line)
                {
                    char lower = Char.ToLower(character);
                    if (char.IsUpper(character))
                    {
                        decoded += Char.ToUpper(cipher[lower]);
                    }
                    else
                    {
                        decoded += cipher[lower];
                    }
                }
                decoded += "\n";
            }
            Console.WriteLine(decoded);
        }
    }
}
