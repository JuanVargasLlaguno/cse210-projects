using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        while (play_again == "yes")
        {
            int guess_n = 1;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.Write("Guess the magic number: ");
            int guess = int.Parse(Console.ReadLine());
            while (guess != number)
            {
                if (guess > number)
                {
                    guess_n += 1;
                    Console.WriteLine("Lower.");
                    guess = int.Parse(Console.ReadLine());

                }
                else if (guess < number)
                {
                    guess_n += 1;
                    Console.WriteLine("Higher");
                    guess = int.Parse(Console.ReadLine());
                }
            }
            if (guess == number)
            {
                Console.WriteLine("Yes! You guessed it!");
                Console.WriteLine($"Number of guesses: {guess_n}");
                Console.Write("Do you want to play again? (yes/no) ");
                play_again = Console.ReadLine();
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}