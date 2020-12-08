using System;
using System.IO;

namespace FileInfo_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //A text file must be created beforehand , for the program to read this file and make a copy to another file

            string sourcePath = @"E:\Advanced-oop\FileInfo-demo\file1.txt"; //original file path
            string targetPath = @"E:\Advanced-oop\FileInfo-demo\file2.txt"; // path of the original file copy

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
