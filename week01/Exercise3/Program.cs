using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Step 1: Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess;
            int guessCount = 0;
            bool isCorrect = false;

            Console.WriteLine("Welcome to 'Guess My Number'!");
            Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it.");

            // Step 2: Loop until the user guesses the magic number
            while (!isCorrect)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    isCorrect = true;
                }
            }

            // Step 3: Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}