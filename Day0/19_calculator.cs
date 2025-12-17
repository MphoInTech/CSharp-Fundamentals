using System;

class Program
{
    static void Main()
    {
        // Read first number
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Read operator
        string op = Console.ReadLine();

        // Read second number
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        if (op == "+")
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        else if (op == "-")
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        else if (op == "*")
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
        else if (op == "/")
        {
            result = num1 / num2;
            Console.WriteLine(result.ToString("F2"));
        }
    }
}
