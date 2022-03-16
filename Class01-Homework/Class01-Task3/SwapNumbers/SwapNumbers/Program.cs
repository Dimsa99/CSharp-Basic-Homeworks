using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create new console application “SwapNumbers”. Input 2 numbers from the console " +
                "and then swap the values of the variables so that the first variable has the second value " +
                "and the second variable the first value. Please find example below:");
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            int numberOne = int.Parse(inputOne);
            int numberTwo = int.Parse(inputTwo);
            Console.WriteLine($"Before swapping:{numberOne} and {numberTwo}");
            numberOne += numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne -= numberTwo;
            Console.WriteLine($"After swapping:{numberOne} and {numberTwo}");
        }
    }
}
