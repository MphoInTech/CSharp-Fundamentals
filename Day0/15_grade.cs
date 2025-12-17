using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the grade calculator!");
        Console.WriteLine("Enter your score");
        // Read the score
        int score = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Here is your grade: ");

        // Check score ranges and print the grade
        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
