using System;
using System.Linq.Expressions;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp) {
                float num1 = 0; float num2 = 0;
                double clean1 = 0; double clean2 = 0;

                Console.WriteLine("Console Calculator \r");
                Console.WriteLine("------------------\r");

                Console.WriteLine("");
                Console.WriteLine("Please enter your first number");
            try 
                { 
                   num1 = Convert.ToInt32(Console.ReadLine());
                }
            
            catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter a number");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("Please enter a second number");
                }

            try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

            catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    Console.WriteLine("");
                    Console.WriteLine("Please enter a number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
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
                    Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "Subtraction":
                case "subtraction":
                    Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "Multiplication":
                case "multiplication":
                    Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "Division":
                case "division":
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
            Console.WriteLine("Press 'n' to close calculator or any other key to continue");

            if (Console.ReadLine() == "n")
            {
                endApp = true;
            }
            }
        }
    }
}