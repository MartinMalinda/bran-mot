using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            WriteMultipleLines("./multi-lines.txt", "Spaghetti", 7);
        }

        public static void WriteMultipleLines(string path, string word, int quantity)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                for (int lines = 0; lines < quantity; lines++)
                {
                    sr.WriteLine(word);
                }
            }
            Console.WriteLine("{0} was written {1} times in the file located at {2}", word, quantity, path);
        }
    }
}
