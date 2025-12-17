using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers and my program will determine if the list is in ascending order");
        // Read the line of numbers
        string input = Console.ReadLine();

        // Split the input into parts
        string[] parts = input.Split(' ');

        // Convert the first number and store it as the previous value
        int previous = Convert.ToInt32(parts[0]);

        bool ascending = true;

        // Loop through the remaining numbers
        for (int i = 1; i < parts.Length; i++)
        {
            int current = Convert.ToInt32(parts[i]);

            // If current number is smaller than the previous, it's not ascending
            if (current < previous)
            {
                ascending = false;
                break;
            }

            // Update previous number
            previous = current;
        }

        // Print result
        if (ascending)
        {
            Console.WriteLine("Ascending");
        }
        else
        {
            Console.WriteLine("Not ascending");
        }
    }
}
