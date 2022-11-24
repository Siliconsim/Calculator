using System;
using System.Linq.Expressions;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                double num1 = 1; double num2 = 1;

                Console.WriteLine("Console Calculator \r");
                Console.WriteLine("------------------\r");

                Console.WriteLine("");
                Console.WriteLine("Please enter the first number:");


                while (double.IsNaN(num1) == false)
                {

                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("This is not a valid number");

                        Console.WriteLine("");
                        Console.WriteLine("Please enter a valid number:");
                    }

                    else
                    {
                        break;
                    }
                };

                Console.WriteLine("");
                Console.WriteLine("Please enter a second number:");

                while (double.IsNaN(num2) == false)
                {
                
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("This is not a valid number");

                        Console.WriteLine("");
                        Console.WriteLine("Please enter a valid number:");
 
                    }

                    else
                    {
                        break;
                    }

                };

            Console.WriteLine("");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("\t1. Addition");
            Console.WriteLine("\t2. Subtraction");
            Console.WriteLine("\t3. Multiplication");
            Console.WriteLine("\t4. Division");
            Console.Write("Operation selected: ");


            switch (Console.ReadLine())
            {
                case "Addition":
                case "addition":
                case "1":
                    Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "Subtraction":
                case "subtraction":
                case "2":
                        Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "Multiplication":
                case "multiplication":
                case "3":
                        Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "Division":
                case "division":
                case "4":
                        while (num2 == 0)
                    {
                        Console.WriteLine("Please enter a non-zero divisor");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("This isn't an operation!");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Type 'close' to close calculator or press any other key to continue");

            Console.Write(">");
            if (Console.ReadLine() == "close" || Console.ReadLine() == "close")
            {
                endApp = true;
            }
            }
        }
    }
}