using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivesList = DriveInfo.GetDrives();
            foreach (DriveInfo myDrives in drivesList)
            {
                Console.WriteLine("Drive {0}", myDrives.Name);
                Console.WriteLine("  File type: {0}", myDrives.DriveType);
                if (myDrives.IsReady == true)
                {
                    Console.WriteLine(" Total size of drive:{0, 15} bytes ", myDrives.TotalSize);
                    Console.Read();
                }
            }
        }
    }
}