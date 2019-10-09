using System;

namespace GreenFox
{
    class Program
    {
        //  Create a function that takes a list of numbers as parameter
        //  Returns a list where the elements are sorted in ascending numerical order
        //  Make a second boolean parameter, if it's `true` sort that list descending

        static void Main(string[] args)
        {
            //  Example:
            Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
            //  should print [5, 9, 12, 24, 34]
            Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]
        }

        public static string Bubble(int[] list)
        {
            int swap = 0;
            string sorted = "";
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i+1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        swap = list[i];
                        list[i] = list[j];
                        list[j]  = swap;
                    }
                    swap = 0;
                }
            }
            sorted = "[";
            foreach (var item in list)
            {
                sorted += item + ", ";
            }
            sorted += "]";
            return sorted;
        }

        public static string AdvancedBubble(int[] list, bool descending)
        {
            if (descending)
            {
                int swap = 0;
                string sorted = "";
                for (int i = 0; i < list.Length; i++)
                {
                    for (int j = i + 1; j < list.Length; j++)
                    {
                        if (list[i] < list[j])
                        {
                            swap = list[i];
                            list[i] = list[j];
                            list[j] = swap;
                        }
                        swap = 0;
                    }
                }
                sorted = "[";
                foreach (var item in list)
                {
                    sorted += item + ", ";
                }
                sorted += "]";
                return sorted;
            }
            else{
                return "error";
            }
            
        }
    }
}