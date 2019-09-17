using System;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        public static int TotalSpending(List<int> expenses)
        {
            int TotalSpending = 0 ;
            foreach (var expense in expenses)
            {
                TotalSpending = TotalSpending + expense;
            }
            return TotalSpending;
        }

        public static int GreatestExpense(List<int> expenses)
        {
            int greatestExpense = 0;
            expenses.Sort();
            greatestExpense = expenses[expenses.Count-1];
            return greatestExpense;
        }
        public static int SmallestExpense(List<int> expenses)
        {
            int smallestExpense = 0;
            expenses.Sort();
            smallestExpense = expenses[0];
            return smallestExpense;
        }
        public static double AverageSpending (List<int> expenses)
        {
            double averageSpending = 0;
            
            averageSpending = TotalSpending(expenses)/expenses.Count;

            return averageSpending;
        }
        static void Main(string[] args)
        {
            //Create a list with the following items.
            List<int> expenses = new List<int>();

            //500, 1000, 1250, 175, 800 and 120
            expenses.AddRange(new int[] { 500, 1000, 1250, 175, 800, 120});

            //Create an application which solves the following problems.
            //How much did we spend?
            Console.WriteLine("Total Spending : " + TotalSpending(expenses));

            //Which was our greatest expense?
            Console.WriteLine("Greatest expense: " + GreatestExpense(expenses));

            //Which was our cheapest spending?
            Console.WriteLine("Smallest Expense: " + SmallestExpense(expenses));

            //What was the average amount of our spendings ?
            Console.WriteLine("Average Spending : " + AverageSpending(expenses));

        }
    }
}
