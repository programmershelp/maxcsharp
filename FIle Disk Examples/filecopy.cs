using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy("testfile.txt", "newfile.txt");
            Console.WriteLine(File.ReadAllText("testfile.txt"));
            Console.WriteLine(File.ReadAllText("newfile.txt"));
            Console.Read();
        }
    }
}