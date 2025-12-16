using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your list of numbers to check which number is bigger than the rest");
        // Read line of numbers
        string input;
        input = Console.ReadLine();

        // Split into parts
        string[] parts = input.Split(' ');

        // Convert first number and assume it's the max
        int max;
        max = Convert.ToInt32(parts[0]);

        // Loop through remaining numbers
        for (int i = 1; i < parts.Length; i++)
        {
            int number = Convert.ToInt32(parts[i]);

            if (number > max)
            {
                max = number;
            }
        }

        // Print result
        Console.WriteLine("You max number is: " + max);
    }
}
