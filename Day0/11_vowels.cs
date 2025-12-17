using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Let's count the number of vowels in your string!");
        // Read input string
        string input;
        // Converts string from user to lowercase (case sensitive)
        input = Console.ReadLine().ToLower();

        int count = 0;

        // Loop through each character in the string
        foreach (char c in input)
        {
            // Check if the character is a vowel
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }

        // Print the number of vowels
        Console.WriteLine("Here are your vowels: ");
        Console.WriteLine(count);
    }
}
