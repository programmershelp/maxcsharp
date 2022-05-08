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
            DateTime time = info.CreationTime;
            Console.WriteLine("File Creation Time     : {0}", time);
            time = info.LastAccessTime;
            Console.WriteLine("File Last Access Time  : {0}", time);
            time = info.LastWriteTime;
            Console.WriteLine("File Last Write Time   : {0} ", time);
            Console.Read();
        }
    }
}