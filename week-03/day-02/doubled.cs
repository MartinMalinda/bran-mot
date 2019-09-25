using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Undouble("./doubled.txt", "./doubledDecrypted.txt");
        }
        public static void Undouble(string input, string output)
        {
            string doubled = File.ReadAllText(input);
            doubled.ToCharArray();
            for (int characters = 0; characters < doubled.Length; characters+=2)
            {
                File.AppendAllText(output, doubled[characters].ToString());
            }
        }
    }
}
