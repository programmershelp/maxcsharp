using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, myNumber;
            Console.Write("Enter the number of elements: ");
            myNumber = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //print 0 and 1  
            
            for (i = 2; i < myNumber; ++i) //loop starts from 2   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}