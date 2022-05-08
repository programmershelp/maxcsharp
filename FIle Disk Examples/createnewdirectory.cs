using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("J:\\MyDirectory");
            Console.WriteLine("MyDirectory is Created in the J Drive");
            Console.ReadLine();
        }
    }
}