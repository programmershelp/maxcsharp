using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber, r, sumNumber = 0, tempNumber;
            // get the user input
            Console.Write("Enter a Number: ");
            myNumber = int.Parse(Console.ReadLine());
            tempNumber = myNumber;
            while (myNumber > 0)
            {
                r = myNumber % 10;
                sumNumber = (sumNumber * 10) + r;
                myNumber = myNumber / 10;
            }
            // display the  result to the user
            if (tempNumber == sumNumber)
                Console.Write("The Number is a Palindrome.");
            else
                Console.Write("The Number is not a Palindrome");

            Console.ReadLine();
        }
    }
}
