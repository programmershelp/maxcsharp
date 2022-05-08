using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myDirFiles = Directory.GetFiles(@"J:\csharp\basics");
            Console.WriteLine("Files in the Directory");
            foreach (string myFiles in myDirFiles)
            {
                Console.WriteLine(myFiles);
            }
            Console.Read();
        }
    }
}