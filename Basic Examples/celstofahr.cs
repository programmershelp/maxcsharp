using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrTemp, celsTemp;
            // get the user input
            Console.Write("Enter the temperature in Celsius:");
            celsTemp = Convert.ToDouble(Console.ReadLine());
            //convert using the formula
            fahrTemp = (celsTemp * 1.8) + 32;
            //display results
            Console.WriteLine("Celsius is {0} -> Fahrenheit is {1}", celsTemp, fahrTemp);

            Console.ReadLine();
        }
    }
}