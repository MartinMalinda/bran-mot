using System;
using System.IO;
using System.Collections.Generic;

namespace trialExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = {  { 1, 0, 1, 7 },
                                { 0, 2, 2, 4},
                                { 1, 2, 5 ,2 },
                                { 7, 1, 2, 5 } };
            


            for (int i = 0; i< myArray.Rank ; i++)
            {
                for (int j = myArray.Rank; j > 0; j--)
                {
                    if (myArray[i, j] != myArray[j,i])
                    {
                        Console.WriteLine("The array is not symmetrical");
                        break;
                    }
                }
                
            }
            Console.WriteLine( ("This array is symmetrical"));

        }
    }
}
