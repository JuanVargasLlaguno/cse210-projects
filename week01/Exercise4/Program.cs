using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter Number: ");
        int u_number = int.Parse(Console.ReadLine());
        while (u_number != 0)
        {
            numbers.Add(u_number);
            Console.Write("Enter Number: ");
            u_number = int.Parse(Console.ReadLine());
        }
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        int n_numbers = numbers.Count;
        int avg = sum / n_numbers;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {largest}");

    }
}