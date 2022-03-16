using System;

namespace Class01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:Create new console application “RealCalculator” " +
                "that takes two numbers from " +
                "the input and asks what operation would the user want to be done " +
                "( +, - , * , / ). Then it returns the result.");

            Console.WriteLine("Enter 2 numbers please:");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int firstValue = int.Parse(firstNumber);
            int secondValue = int.Parse(secondNumber);


            Console.WriteLine("What kind of operation would you like to use for the numbers?");
            string input;
            input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    {
                        int result1 = firstValue + secondValue;
                        Console.WriteLine(result1);
                    }
                    break;
                case "-":
                    {
                        int result2 = firstValue - secondValue;
                        Console.WriteLine(result2);
                    }
                    break;
                case "*":
                    {
                        int result3 = firstValue * secondValue;
                        Console.WriteLine(result3);
                    }
                    break;
                case "/":
                    {
                        int result4 = firstValue / secondValue;
                        Console.WriteLine(result4);
                    }
                    break;
                default:
                    {
                        Console.WriteLine($"Error! Invalid operator {input}");
                    }
                    break;
            }



        }
    }
}
