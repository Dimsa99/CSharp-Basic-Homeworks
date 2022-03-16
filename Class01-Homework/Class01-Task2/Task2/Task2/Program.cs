using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number!");
            Console.WriteLine("Enter 4 numbers so we can see the avg of them:");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine(); 
            string numberThree = Console.ReadLine();
            string numberFour = Console.ReadLine();

            int numberOneParsed = int.Parse(numberOne);
            int numberTwoParsed = int.Parse(numberTwo);
            int numberThreeParsed = int.Parse(numberThree);
            int numberFourParsed = int.Parse(numberFour);
            if(numberOneParsed == 0 && numberTwoParsed == 0 && numberThreeParsed == 0 && numberFourParsed == 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
            }
            else
            {
                int avgNumbers = (numberOneParsed + numberTwoParsed + numberThreeParsed + numberFourParsed) / 4;
                Console.WriteLine($"The average of {numberOneParsed}, {numberTwoParsed},{numberThreeParsed} and {numberFourParsed} is: {avgNumbers}");
            }
            
        }
    }
}
