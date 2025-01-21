﻿using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        // Get user input
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Display menu
        Console.WriteLine("\nSelect operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        // Display result
        if (choice >= 1 && choice <= 4 && num2 != 0)
        {
            Console.WriteLine("\nResult: " + result);
        }
    }
}