using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            Console.Write("\n Print even or odd numbers in a given range :\n");

            Console.Write(" Input the range to print from 1 : ");
            myNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n All even numbers from 1 to {0} are : ", myNumber);
            EvenOrOdd(2, myNumber); //call the function for even numbers 

            Console.WriteLine("\n\n All odd numbers from 1 to {0} are : ", myNumber);
            EvenOrOdd(1, myNumber); // call the function for odd numbers
            Console.WriteLine("\n\n");
            Console.ReadLine();
            return;
        }

        static void EvenOrOdd(int stVal, int n)
        {
            if (stVal > n)
                return;
            Console.Write(" {0} ", stVal);
            EvenOrOdd(stVal + 2, n); //calling the function EvenAndOdd recursively
        }
    }
}