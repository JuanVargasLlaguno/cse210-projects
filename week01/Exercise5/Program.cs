using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int fav_number = PromptUserNumber();
        int square = SquareNumber(fav_number);
        DisplayResult(user_name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}