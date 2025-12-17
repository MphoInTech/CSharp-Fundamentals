using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a lsit of numbers: ");
        // Read the number as a string
        string input = Console.ReadLine();

        int sum = 0;

        // Loop through each character in the string
        foreach (char c in input)
        {
            // Convert character digit to integer and add to sum
            sum += c - '0';
        }

        // Print the sum of 
        Console.WriteLine("Here are the sum of digits: ");
        Console.WriteLine(sum);
    }
}
