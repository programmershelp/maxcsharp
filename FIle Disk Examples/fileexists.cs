using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo info = new FileInfo("J:\\csharp\\testfile.txt");
            bool exists = info.Exists;
            if (exists == true)
            {
                Console.WriteLine("The File Exists");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.Read();
        }
    }
}