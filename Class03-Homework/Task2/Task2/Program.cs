using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student group!");
            Console.WriteLine("Please enter 1 or 2 for which group you want to print out.");
            string input;
            input = Console.ReadLine();
            string[] groupOne = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] groupTwo = { "Zoki", "Mile", "Marko", "Martin", "Vojdan" };
            
            switch (input)
            {
                case "1":
                    {
                        foreach (string person in groupOne)
                        {
                            Console.WriteLine(person);
                        }
                    }
                    break;
                case "2":
                    {
                        foreach (string person in groupTwo)
                        {
                            Console.WriteLine(person);
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
            }
        }
    }
}
