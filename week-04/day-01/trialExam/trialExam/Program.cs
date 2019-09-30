using System;
using System.IO;
using System.Collections.Generic;

namespace trialExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MostCommonCharacters("./countchar.txt")); 
        }
        public static string MostCommonCharacters(string filename)
        {
            string fileContent = File.ReadAllText(filename);
            fileContent.ToCharArray();
            Dictionary<char, int> characterDictionary = new Dictionary<char, int>();

            foreach (var character in fileContent)
            {
                if (characterDictionary.ContainsKey(character))
                {
                    characterDictionary[character]++;
                }
                else
                {
                    characterDictionary.Add(character, 1);
                }
            }

            int[] characterCounts = new int[characterDictionary.Count];
            char[] characters = new char[characterDictionary.Count];
            int counter = 0;
            foreach (KeyValuePair<char, int> item in characterDictionary)
            {
                characters[counter] = item.Key;
                characterCounts[counter] = item.Value;
                counter++;
            }
            Array.Sort(characterCounts, characters);

            string retrunString = "";

            for (int i = characters.Length-1; i > characters.Length-3; i--)
            {
                retrunString = retrunString + characters[i] +": "+ characterCounts[i] +"\n";
            }

            return retrunString;
        }
    }
}
