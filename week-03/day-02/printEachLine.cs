using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"
            try
            {
                string[] fileLines = File.ReadAllLines(@"/Users/Brandon/greenfox/bran-mot/week-03/day-02/my-file.txt");
                foreach (var line in fileLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}
