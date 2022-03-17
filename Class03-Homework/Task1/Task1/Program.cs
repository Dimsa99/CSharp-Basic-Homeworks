using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a console application called SumOfEven. " +
                "Inside it create an array of 6 integers. Get numbers from the input, " +
                "find and print the sum of the even numbers from the array:");


            Console.WriteLine("SumOfEven");
            int sum = 0;
            int[] array = new int[6];
            Console.WriteLine("Enter 6 numbers!");
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = Console.Read();
                //Console.WriteLine(array[i]);
                //if(array[i] %2 == 0)
                //{

                //}

                
                string input = Console.ReadLine();
                int.TryParse(input, out int parsedInput);
                array[i] = parsedInput;
                if(parsedInput % 2 == 0)
                {
                    sum += parsedInput;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sum);
            

        }
    }
}
