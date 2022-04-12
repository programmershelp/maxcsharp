using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString1;
            String myString2;
            //prompt user to enter string
            Console.Write("Enter string : ");
            //store string as myString1
            myString1 = Console.ReadLine();
            //convert to upper case
            myString2 = myString1.ToUpper();
            //display the user entered string in upper case
            Console.WriteLine("The Converted upper case string is: " + myString2);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}