using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type something to see some magic!!!");
        // Read input string
        string input;
        input = Console.ReadLine();

        // Convert to char array
        char[] chars = input.ToCharArray();

        // Reverse the array
        Array.Reverse(chars);

        // Convert back to string
        string reversed = new string(chars);

        // Print result
        Console.WriteLine(reversed);
        Console.WriteLine("Cool right ?");
    }
}
