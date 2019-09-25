using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            Console.WriteLine(Copyfiles("./source.txt", "./destination.txt")); 
        }

        public static bool Copyfiles(string source, string destination)
        {
            try
            {
                string lineToWrite = "";
                using (StreamReader streamReader = new StreamReader(source))
                {
                    lineToWrite = streamReader.ReadLine();
                    while (lineToWrite != null)
                    {
                        File.AppendAllText(destination, lineToWrite+"\n");
                        lineToWrite = streamReader.ReadLine();
                    }
                }
                return true;
            } catch (IOException e)
            {
                return false;
            }
        }
    }
}
