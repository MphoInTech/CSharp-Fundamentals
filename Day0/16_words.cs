using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Let's count the number of words in a sentence!");
        Console.WriteLine("Please write something ?");
        // Read the full line of text
        string input = Console.ReadLine();

        // Split the line by spaces, ignoring extra spaces
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // The number of words is the length of the array
        Console.WriteLine("Number of words in the array: " + words.Length);
    }
}
