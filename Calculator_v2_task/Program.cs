using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        char opr;
        float first, second;

        while (true)
        {
            try
            {
                Console.Write("Enter an operation (+, -, /, *): ");
                opr = Console.ReadLine()[0];

                // 'Contains' method checks if a string contains a character or a substring.
                if ("/-+*".Contains(opr))
                    break;

            }
            catch { }
            Console.WriteLine("The operator is invalid.");
        }

        while (true)
        {
            try
            {
                Console.Write("Enter the first number: ");
                first = float.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("The first number is invalid. ");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Enter the second number: ");
                second = float.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("The second number is invalid. ");
            }
        }


        float result = 0;
        if (opr == '+')
            result = first + second;
        else if (opr == '-')
            result = first - second;
        else if (opr == '/')
            result = first / second;
        else if (opr == '*')
            result = first * second;

        Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
    }
}