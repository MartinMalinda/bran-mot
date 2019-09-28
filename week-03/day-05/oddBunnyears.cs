using System;

namespace recursion
{
    class Program
    {
        //We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies(1, 3, ..) have the normal 2 ears.The even bunnies(2, 4, ..)
        //we'll say have 3 ears, because they each have a raised foot. Recursively return the number
        //of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

        static void Main(string[] args)
        {
            Console.WriteLine(OddBunnyEars(4));
        }

       public static int OddBunnyEars(int bunnies)
        {
            if (bunnies == 1)
            {
                return 3;
            } else if(bunnies%2 == 0)
            {
                return 2 + OddBunnyEars(bunnies - 1);
            }
            else
            {
                return 3 + OddBunnyEars(bunnies - 1);
            }
        }
    }
}
