using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("You failed the class. Better luck next time!");
        }
    }
}