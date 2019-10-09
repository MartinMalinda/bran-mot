using System;

namespace oldExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            Console.WriteLine("Please Provide a maximum limit for the range of numbers: ");
            int upperLimit = int.Parse(Console.ReadLine());
            int userGuess = 0;
            int lives = 5;
            bool userWins = false;

            int numberToGuess = randomNumber.Next(1, upperLimit);

            Console.WriteLine("Guess a number between 1 and {0}", upperLimit);

            while (lives > 0)
            {
                if (userGuess == numberToGuess)
                {
                    userWins = true;
                    break;
                }
                else if (userGuess > numberToGuess)
                {
                    lives--;
                    Console.WriteLine($"Too high. Guess Again. You have {lives} lives left.");
                }
                else if (userGuess < numberToGuess && userGuess > 0)
                {
                    lives--;
                    Console.WriteLine($"Too Low. Guess Again. You have {lives} lives left.");
                }
                userGuess = int.Parse(Console.ReadLine());
            }

            if (userWins)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
        }
    }
}
