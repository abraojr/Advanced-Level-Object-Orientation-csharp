using System;
using System.IO;

namespace Using_block_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Advanced-oop\Using-block-02\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
