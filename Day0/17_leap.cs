using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any year to find out if its a leap year or not");
        // Read the year
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("This year is...");

        // Check leap year conditions
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("A leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }
    }
}
