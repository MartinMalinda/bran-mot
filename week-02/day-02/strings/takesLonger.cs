using System;
using System.Text;
namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            string firstPart = quote.Substring(0,21);
            string secondPart = quote.Substring(20);
            string inBetweenPart = "always takes longer than";

            var combinedString = new StringBuilder();
            combinedString.Append(firstPart).Append(inBetweenPart).Append(secondPart);

            quote = combinedString.ToString(0, combinedString.Length);

            Console.WriteLine(quote);
        }
    }
}