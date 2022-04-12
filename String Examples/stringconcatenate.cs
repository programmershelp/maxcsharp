using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "";
            string myString2 = "";
            string myString3 = "";
            // Get first string from user
            Console.Write("Enter string1: ");
            myString1 = Console.ReadLine();
            // Ger second string from user
            Console.Write("Enter string2: ");
            myString2 = Console.ReadLine();
            // JOin the 2 strings
            myString3 = String.Concat(myString1, myString2);
            // Display the concatenated string
            Console.WriteLine("The concatenated string is: {0}", myString3);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}