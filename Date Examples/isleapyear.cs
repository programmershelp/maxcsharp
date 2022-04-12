using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myYear;
            Console.Write("Input an year : ");
            myYear = Convert.ToInt32(Console.ReadLine());

            if ((myYear % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", myYear);
            else if ((myYear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", myYear);
            else if ((myYear % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", myYear);
            else
                Console.WriteLine("{0} is not a leap year.\n", myYear);
            Console.ReadLine();
        }
    }
}