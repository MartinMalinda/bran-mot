using System;

namespace Reverse
{
    public class Reverse
    {
        public static string ReverseString(string toBeReversed)
        {
            char[] lettersForReversal = toBeReversed.ToCharArray();
            Array.Reverse(lettersForReversal);
            string fixedString = String.Join("", lettersForReversal);
            return fixedString;
        }
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseString(reversed));
        }
    }
}