using System;
using System.Collections.Generic;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that
            // - takes the name of a CSV file as a parameter,
            //   - every row is in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - returns the year when the most births happened.
            //   - if there were multiple years with the same number of births then return any one of them

            // You can find such a CSV file in this directory named births.csv
            // If you pass "births.csv" to your function, then the result should be either 2006, or 2016.
            Console.WriteLine(HighestYearlyBirths("./births.csv"));
        }
        public static string HighestYearlyBirths(string input)
        {
            string yearOfMostBirths = "";
            Dictionary<string, int> births = new Dictionary<string, int>();
            string[] birthsLines = File.ReadAllLines(input);
            string[] birthsSplit = new string[3];
            for (int i = 0; i < birthsLines.Length; i++)
            {
                birthsSplit = birthsLines[i].Split(new char[] { ';' });
                string birthYear = birthsSplit[1].Substring(0, 4);

                foreach (var birth in birthsSplit)
                {
                    if (births.ContainsKey(birthYear))
                    {
                        births[birthYear] += 1;
                    }
                    else
                    {
                        births.Add(birthYear, 1);
                    }
                }
            }
            string[] birthYears = new string[births.Count];
            int[] birthCounts = new int[births.Count];
            int count = 0;

            foreach (KeyValuePair<string, int> birth in births)
            {
                birthYears[count] = birth.Key;
                birthCounts[count] = birth.Value;
                count++;
            }
            Array.Sort(birthCounts, birthYears);
            yearOfMostBirths = birthYears[birthYears.Length - 1];

            return yearOfMostBirths;
            
        }
    }
}
