using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "maxcsharp";
            // compare myString to maxcsharp
            // then display outcome to user depending on the comparison
            if (myString.CompareTo("maxcsharp") == 0)
            {
                Console.WriteLine("String is a match");
            }
            else
            {
                Console.WriteLine("String is not a match");
            }

            // compare myString to maxpython
            // then display outcome to user depending on the comparison
            if (myString.CompareTo("maxpython") == 0)
            {
                Console.WriteLine("String is a match");
            }
            else
            {
                Console.WriteLine("String is not a match");
            }
        }
    }
}