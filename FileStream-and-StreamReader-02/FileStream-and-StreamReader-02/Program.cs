using System;
using System.IO;

namespace FileStream_and_StreamReader_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Advanced-oop\FileStream-and-StreamReader-02\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
