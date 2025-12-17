using System;

class Program
{
    static void Main()
    {
        // Ask user for input
        Console.WriteLine("Let's count the number of digits in a list of numbers!");
        Console.WriteLine("Enter your number list:");

        // Read the number as a string
        string input = Console.ReadLine();

        // The number of digits is the length of the string
        int digitCount = input.Length;

        // Print the result
        Console.WriteLine("There are: " + digitCount + " digits.");
    }
}
