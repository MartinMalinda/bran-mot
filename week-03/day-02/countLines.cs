using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            Console.WriteLine(LineCount("my-file.txt"));
            Console.WriteLine(LineCount("file.txt"));
        }
        public static int LineCount(string file)
        {
            string pathName = @"/Users/Brandon/greenfox/bran-mot/week-03/day-02/";
            try
            {
                string[] fileLines = File.ReadAllLines(pathName + file);
                return fileLines.Length;
            } catch (IOException e)
            {
                return 0;
            }
        }
    }
}
