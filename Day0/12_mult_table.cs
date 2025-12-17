using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Let's find out the mutliplication tabel for the number of your choice!");
        Console.WriteLine("Please enter a number");
        // Read the number from the user
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Here are the multiples of " + n + ":");

        // Loop from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            // Calculate the result
            int result = n * i;

            // Print in the required format
            Console.WriteLine(n + " x " + i + " = " + result);
        }
    }
}
