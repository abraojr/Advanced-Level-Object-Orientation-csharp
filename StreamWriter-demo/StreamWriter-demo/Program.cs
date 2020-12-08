using System;
using System.IO;

namespace StreamWriter_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program will read the lines of the original file and pass the content of this file to another , with the letters in capitals.

            string sourcePath = @"E:\Advanced-oop\StreamWriter-demo\file1.txt";
            string targetPath = @"E:\Advanced-oop\StreamWriter-demo\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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
