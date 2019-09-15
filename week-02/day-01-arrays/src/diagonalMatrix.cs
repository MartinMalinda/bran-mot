using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] matrix = new int[4,4];

            for (int rows = 0; rows < 4; rows++)
            {
                for (int columns = 0; columns < 4; columns++)
                {
                    if (rows == columns) {
                        matrix[rows, columns] = 1;
                    }
                    else
                    {
                        matrix[rows,columns] = 0;
                    }
                    Console.Write(matrix[rows, columns] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}