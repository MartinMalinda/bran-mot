using System;

namespace recursion
{
    class Program
    {
        // Given a string, compute recursively (no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
        static void Main(string[] args)
        {
            Console.WriteLine(BunnyEars(25));
        }

        public static int BunnyEars(int n)
        {
            if(n==1)
            {
                return 2;
            }
            return 2 + BunnyEars(n - 1);
        }
    }
}