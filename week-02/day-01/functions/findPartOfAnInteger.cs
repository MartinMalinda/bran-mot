using System;

namespace GreenFox
{
    class Program
    {
        public static int[] SubInt(int numberToFind, int[] arrayToSearch)
        {
            int[] foundNumbers = new int[0];
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i].ToString().Contains(numberToFind.ToString()) == true)
                {
                    Array.Resize(ref foundNumbers, foundNumbers.Length + 1);
                    foundNumbers[foundNumbers.Length-1] = i;
                }
                else {
                    i++;
                }

            }
            
            return foundNumbers;
            /*foreach (var number in foundNumbers)
            {
                Console.Write(number + ", ");
            }*/
        }
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            foreach (var item in SubInt(1, new int[] { 1, 11, 34, 52, 61 }))
            {
                Console.Write(item +", ");
            }
            SubInt(1, new int[] { 1, 11, 34, 52, 61 });
            //  should print: `[0, 1, 4]`
            Console.wrte
            foreach (var item in SubInt(9, new int[] { 1, 11, 34, 52, 61 }))
            {
                Console.Write(item + ", ");
            }
            
            //  should print: '[]'
        }
    }
}