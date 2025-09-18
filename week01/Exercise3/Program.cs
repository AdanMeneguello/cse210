using System;

class Program

{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int attempts = 0;

            Console.WriteLine("Guess My Number (1 to 100).");

            int guess;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

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
                    Console.WriteLine($"Attempts: {attempts}");
                }
            } while (guess != magicNumber);

            Console.Write("Play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
    } 
}