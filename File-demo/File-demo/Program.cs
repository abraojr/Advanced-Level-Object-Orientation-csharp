using System;
using System.IO;

namespace File_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //A text file must be created beforehand , for the program to read this file and make a copy to another file

            string sourcePath = @"E:\Advanced-oop\File-demo\file1.txt"; //original file path
            string targePath = @"E:\Advanced-oop\File-demo\file2.txt"; // path of the original file copy

            try
            {
                File.Copy(sourcePath, targePath);
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
