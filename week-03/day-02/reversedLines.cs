using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt

            ReverseText("./reversedChars.txt", "./reversedCharsDecrypted.txt");
        }

        public static void ReverseText(string input, string output)
        {
            string lineToReverse = "";
            using (StreamReader streamReader = new StreamReader(input))
            {
                lineToReverse = streamReader.ReadLine();
                while (lineToReverse != null)
                {
                    char[] charactersToReverse = lineToReverse.ToCharArray();
                    Array.Reverse(charactersToReverse);
                    string fixedLine = String.Join("", charactersToReverse);
                    File.AppendAllText(output, fixedLine + "\n");
                    lineToReverse = streamReader.ReadLine();
                }
            }
        }
    }
}