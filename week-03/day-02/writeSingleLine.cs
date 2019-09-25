using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            WriteMyName("Brandon", "my-file.txt");
            WriteMyName("Brandon", "other-file.txt");

        }
        public static void WriteMyName(string name, string file)
        {
            string filePath = @"/Users/Brandon/greenfox/bran-mot/week-03/day-02/";
            try
            {
                if (File.Exists(file))
                {
                    using (StreamWriter sw = new StreamWriter(filePath + file))
                    {
                        sw.WriteLine(name);
                    }
                    Console.WriteLine("{0} was written to {1}", name, file);
                }
                else
                {
                    throw new IOException();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            
            
        }
    }
}
