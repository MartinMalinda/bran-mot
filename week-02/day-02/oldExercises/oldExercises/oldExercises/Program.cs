using System;

namespace oldExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where the program chooses a number between 1 and 100.The player is then asked to enter a guess. If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.

            //Make the range customizable(ask for it before starting the guessing).
            //You can add lives. (optional)
            //Example

            //I've the number between 1-100. You have 5 lives.

            //> 20
            //Too high. You have 4 lives left.

            //> 10
            //Too low. You have 3 lives left.

            //> 15
            //Congratulations.You won!
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
