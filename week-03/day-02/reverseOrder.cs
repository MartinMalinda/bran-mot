using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt

            ReverseOrder("./reversedOrder.txt", "./reversedOrderDecrypted.txt");
        }

        public static void ReverseOrder(string input, string output)
        {
            string[] fileLines = File.ReadAllLines(input);
            for (int i = fileLines.Length-1; i >= 0; i--)
            {
                File.AppendAllText(output, fileLines[i] + "\n");
            }
        }
    }
}