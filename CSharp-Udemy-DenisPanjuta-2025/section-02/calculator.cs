using System;
using System.Collections.Generic;
using System.Text;

namespace section_02
{
    internal class Calculator
    {
        public static void Run()
        {
            Console.WriteLine("Enter the first number:");
            string? input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string? input2 = Console.ReadLine();
            Console.WriteLine("Choose an operation: +, -, *, /");
            string? arithmeticOperation = Console.ReadLine();


            bool number1 = double.TryParse(input1, out double n1);
            bool number2 = double.TryParse(input2, out double n2);

            if (number1 && number2)
            {
                
                switch (arithmeticOperation)
                {
                    case "+":
                        Console.WriteLine($"Result: {n1 + n2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {n1 - n2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {n1 * n2}");
                        break;
                    case "/":
                        if (n2 != 0)
                        {
                            Console.WriteLine($"Result: {n1 / n2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
    }
}
