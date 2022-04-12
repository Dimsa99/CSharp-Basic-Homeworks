using System;
using System.Collections;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input numbers so we can store them in queue.");
            do
            {
                
                string input = Console.ReadLine();
                bool isParsed = int.TryParse(input, out int result);
                Queue myNumbers = new Queue();
                myNumbers.Enqueue(result);
                if (isParsed)
                {
                    foreach (int number in myNumbers)
                    {
                        Console.WriteLine("Do you want to enter 1 more number? Enter N for exit");
                        Console.WriteLine(number);
                    }
                } else
                {
                    Console.WriteLine("Invalid input");
                }
                
                
            } while (Console.ReadLine().ToLower() != "n");
        }

        //public static int InputNumbers()
        //{
           
        //}
    }
}
