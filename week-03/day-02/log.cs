using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPostRatio("./log.txt")); 
            foreach (var ipAddress in GetIPArray("./log.txt"))
            {
                Console.WriteLine(ipAddress);
            }
        }
        public static string[] GetIPArray(string input)
        {
            string[] logLines = File.ReadAllLines(input);
            string[] ipAddresses = new string[logLines.Length];
            int counter = 0;
            foreach (var entry in logLines)
            {
                ipAddresses[counter] = logLines[counter].Substring(27, 8);
                counter++;
            }
            return ipAddresses;
        }
        public static string GetPostRatio(string input)
        {
            string[] logLines = File.ReadAllLines(input);
            int get = 0;
            int post = 0;
            foreach (string item in logLines)
            {
                if (item.Substring(41, 3) == "GET")
                {
                    get++;
                }
                else
                {
                    post++;
                }
            }
            return $"The ratio of GET:POST is: {get}:{post}";
        }
    }
}
