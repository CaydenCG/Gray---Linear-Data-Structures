using System;
using System.Collections.Generic;

abstract class NumberGenerator
{
    public abstract List<int> GenerateNumbers(int count);
}

class RandomNumberGenerator : NumberGenerator
{
    private Random random = new Random();

    public override List<int> GenerateNumbers(int count)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Add(random.Next(1, 101)); // Generates random numbers from 1 to 100
        }
        return numbers;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            NumberGenerator generator = new RandomNumberGenerator();
            List<int> randomNumbers = generator.GenerateNumbers(20);

            Console.WriteLine("Generated random numbers:");
            DisplayNumbers(randomNumbers);

            Stack<int> numberStack = new Stack<int>();

            foreach (int number in randomNumbers)
            {
                numberStack.Push(number);
            }

            Console.WriteLine("\nReversed random numbers:");

            while (numberStack.Count > 0)
            {
                int number = numberStack.Pop();
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void DisplayNumbers(List<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}
//hello