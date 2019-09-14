using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("How big of a pyramid do you want to make?");
            int userNumber = int.Parse(Console.ReadLine());
            string star = "*";
            string blank = "-";


            for (int i = 0; i < userNumber; i++)
            {
                //render spaces
                for (int j = userNumber - i; j > 1; j--)
                {
                    Console.Write("-");
                 
                }
                for (int k = 1; k <= i; k+=2)
                {
                    if (k == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("**");
                    }
                }
                Console.WriteLine();
            }
       
        }
    }
}

/*using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            int lineCount = 6;
            for (int i = 1; i <= lineCount/2; i++)
            {
                //render the lines
                //Console.WriteLine(i + " | render 5 lines");
                //for each line, render spaces
                for (int j = lineCount/2 -i ; j > 0; j--)
                {
                    Console.Write("-");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("**");
                    
                }
                Console.WriteLine();
                
            }

        }
    }
}
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("How big of a pyramid do you want to make?");
            int userNumber = int.Parse(Console.ReadLine());
            string star = "*";
            string blank = "-";


            for (int i = 0; i < userNumber; i++)
            {
                //render spaces
                for (int j = userNumber - i; j > 1; j--)
                {
                    Console.Write("-");

                }

                //2*i-1 - basically calculate the number of x's in RELATIONSHIP to i

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}*/

