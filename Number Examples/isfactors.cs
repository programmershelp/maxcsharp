using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number = 0;

            Console.Write("Enter an integer : ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("The factors of " + number + " are :");

            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}